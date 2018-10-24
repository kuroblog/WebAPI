
namespace WebApp.CallWebService.Models
{
    using JHWR;
    using Newtonsoft.Json;

    public class DoTransRequestDto<TRequest>
    {
        public string TransCode { get; } = string.Empty;

        public string InJsonString { get; } = string.Empty;

        public DoTransRequestDto(string transCode, TRequest requestDto)
        {
            TransCode = transCode;
            InJsonString = typeof(TRequest) == typeof(string) ? requestDto.ToString() : JsonConvert.SerializeObject(requestDto);
        }

        public DoTransRequest Body
        {
            get { return new DoTransRequest(new DoTransRequestBody(TransCode, InJsonString)); }
        }
    }
}
