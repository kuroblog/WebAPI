
namespace WebApp.CallWebService.Extensions
{
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Models;

    public static class HttpRequestExtensions
    {
        public static async Task<(bool isParsed, Exception error, TResult data)> ParseTo<TResult>(this HttpRequest request, Encoding encoding = null)
            where TResult : class
        {
            var result = await Runner.Execute(async () =>
            {
                if (encoding == null)
                {
                    encoding = Encoding.UTF8;
                }

                var jsonBody = string.Empty;

                if (request.Body.CanSeek)
                {
                    if (request.Body.Position == request.ContentLength)
                    {
                        request.Body.Position = 0;
                    }
                }

                using (var reader = new StreamReader(request.Body, Encoding.UTF8))
                {
                    jsonBody = reader.ReadToEnd();
                }

                var jsonResult = JsonConvert.DeserializeObject<TResult>(jsonBody);

                return await Task.FromResult(jsonResult);
            });

            return await Task.FromResult((result.hasError == false, result.error, result.data));
        }
    }

    public static class TestRequestDtoExtensions
    {
        public static DoTransRequestDto<TRequest> GetRequestData<TRequest>(this TestRequestDto dto)
        {
            return new DoTransRequestDto<TRequest>(dto.code, dto.data);
        }
    }
}
