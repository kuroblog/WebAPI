
namespace WebApp.CallWebService.Extensions
{
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Models;

    public static class HttpRequestExtensions
    {
        public static async Task<TResult> ParseTo<TResult>(this HttpRequest request, Encoding encoding = null)
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

            var result = JsonConvert.DeserializeObject<TResult>(jsonBody);

            return await Task.FromResult(result);
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
