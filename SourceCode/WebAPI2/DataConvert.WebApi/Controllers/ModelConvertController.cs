
namespace DataConvert.WebApi.TextConvert.Controllers
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class TextConvertController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Hello([FromUri]string user = "guest")
        {
            var resultMessage = await Task.FromResult($"Hello {user}, Welcome to access my api on {DateTime.UtcNow}");

            return Ok(resultMessage);
        }

        //[HttpPost]
        //public async Task<IHttpActionResult> Convert()
        //{
        //    var postContent = await Request.Content.ReadAsStringAsync();
        //    return new TextResult(postContent, Request);
        //}

        [HttpPost]
        public async Task<IHttpActionResult> Convert()
        {
            var result = await Task.Run(() =>
            {
                var models = new List<TestModel>();
                Exception error = null;

                try
                {
                    var postContent = Request.Content.ReadAsStringAsync().Result;

                    var contentSplitArray = Helper.SplitContent(postContent, Environment.NewLine);

                    var lineNumber = 1;
                    contentSplitArray.ToList().ForEach(s =>
                    {
                        var model = Helper.ConvertTo<TestModel>(s);

                        var errors = Helper.ValidationModel(model);

                        if (errors.Length > 0)
                        {
                            throw new ValidationException($"Line.{lineNumber}'s Error: {string.Concat(errors)}");
                        }

                        models.Add(model);

                        lineNumber++;
                    });
                }
                catch (Exception ex)
                {
                    error = ex;
                }

                return Tuple.Create(models, error);
            });

            if (result.Item2 != null)
            {
                return InternalServerError(result.Item2);
            }

            return Ok(result.Item1);
        }
    }

    public class Helper
    {
        private const char splitChar = '\t';

        public static string[] SplitContent(string stringContent, string splitString)
        {
            if (string.IsNullOrEmpty(stringContent.Trim()))
            {
                throw new ArgumentNullException(nameof(stringContent));
            }

            if (string.IsNullOrEmpty(splitString))
            {
                throw new ArgumentNullException(nameof(splitString));
            }

            stringContent = stringContent.TrimEnd(splitString.ToArray());

            return stringContent.Split(splitString.ToCharArray()).Where(s => string.IsNullOrEmpty(s) == false).ToArray();
        }

        public static string[] ValidationModel<TDtoModel>(TDtoModel model) where TDtoModel : IDtoModel, new()
        {
            var validationMessages = new List<string>();
            model.GetType().GetProperties().ToList().ForEach(p =>
            {
                p.GetCustomAttributes(typeof(ValidationAttribute), false).ToList().ForEach(v =>
                {
                    var validation = v as ValidationAttribute;
                    var pValue = p.GetValue(model);
                    var description = p.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
                    var pName = description == null ? p.Name : (description as DescriptionAttribute).Description;

                    if (!validation.IsValid(pValue))
                    {
                        validationMessages.Add($"{pName}'s value is {pValue ?? "Empty"} & {validation.FormatErrorMessage(pName)}");
                    }
                });
            });

            return validationMessages.ToArray();
        }

        public static TDtoModel ConvertTo<TDtoModel>(string modelString) where TDtoModel : IDtoModel, new()
        {
            if (string.IsNullOrEmpty(modelString))
            {
                throw new ArgumentNullException(nameof(modelString));
            }

            var modelValueArray = modelString.Split(splitChar);
            if (modelValueArray.Length <= 0)
            {
                throw new IndexOutOfRangeException(nameof(modelString));
            }

            var modelResult = Activator.CreateInstance<TDtoModel>();

            modelResult.GetType().GetProperties().ToList().ForEach(p =>
            {
                var attribute = p.GetCustomAttributes(typeof(TagAttribute), false).FirstOrDefault();
                if (attribute != null)
                {
                    var tag = attribute as TagAttribute;
                    var pIndex = tag.Index;
                    if (pIndex >= modelValueArray.Length)
                    {
                        throw new IndexOutOfRangeException(nameof(modelString));
                    }

                    var pType = p.PropertyType;
                    pType = Nullable.GetUnderlyingType(pType) ?? pType;

                    var pValueSource = modelValueArray[pIndex];
                    var pValue = string.IsNullOrEmpty(pValueSource.Trim()) ? null : Convert.ChangeType(pValueSource, pType);

                    p.SetValue(modelResult, pValue);
                }
            });

            return modelResult;
        }
    }

    public class TagAttribute : Attribute
    {
        public int Index { get; private set; }

        public TagAttribute(int index)
        {
            Index = index;
        }
    }

    public interface IDtoModel { }

    public class TestModel : IDtoModel
    {
        [Tag(0), Range(100, 999), Description("主键")]
        public int Id { get; set; }

        [Tag(1), StringLength(50, MinimumLength = 3), Description("描述")]
        public string Text { get; set; }

        [Tag(2), Required, Description("标记")]
        public bool? Flag { get; set; }

        [Tag(3), Required, Description("版本")]
        public DateTime? Version { get; set; }
    }

    public class TextResult : IHttpActionResult
    {
        private HttpResponseMessage responseMessage;
        private HttpRequestMessage requestMessage;
        private string content;

        public TextResult(string content, HttpRequestMessage requestMessage)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException(nameof(content));
            }

            if (requestMessage == null)
            {
                throw new ArgumentNullException(nameof(requestMessage));
            }

            this.content = content;
            this.requestMessage = requestMessage;
        }

        public async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            responseMessage = new HttpResponseMessage();
            responseMessage.Content = new StringContent(content);
            responseMessage.RequestMessage = requestMessage;

            return await Task.FromResult(responseMessage);
        }
    }
}
