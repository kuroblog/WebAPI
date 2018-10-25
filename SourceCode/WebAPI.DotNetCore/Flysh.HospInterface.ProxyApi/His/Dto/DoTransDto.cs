
namespace Flysh.HospInterface.ProxyApi.His.Dto
{
    using JHWR;
    using Newtonsoft.Json;
    using System;

    public class DoTransDto<TRequestData>
    {
        public string Code { get; } = string.Empty;

        public TRequestData RequestData { get; }

        private DoTransRequest body = null;

        public DoTransRequest Body
        {
            get
            {
                if (body == null)
                {
                    var jsonString = typeof(TRequestData) == typeof(string) ? Convert.ToString(RequestData) : JsonConvert.SerializeObject(RequestData);
                    body = new DoTransRequest(new DoTransRequestBody(Code, jsonString));
                }

                return body;
            }
        }

        public DoTransDto(string code, TRequestData requestData)
        {
            Code = code;
            RequestData = requestData;
        }
    }
}
