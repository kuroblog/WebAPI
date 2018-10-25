
namespace Flysh.HospInterface.ProxyApi.His.Dto
{
    using Gboxt.Common.DataModel;
    using JHWR;
    using Newtonsoft.Json;

    public class HisDoTransRequest<TData> : IApiArgument
    {
        public virtual string code { get; set; }

        public virtual TData data { get; set; }

        public bool Validate(out string message)
        {
            message = string.Empty;

            return string.IsNullOrEmpty(message);
        }
    }

    public static class HisDoTransRequestExtensions
    {
        public static DoTransRequest GetRequestData<THisDoTransRequest, TData>(this THisDoTransRequest request)
            where THisDoTransRequest : HisDoTransRequest<TData>
        {
            var jsonString = request.data == null ? string.Empty : request.data.GetType() == typeof(string) ? $"{request.data}" : JsonConvert.SerializeObject(request.data);

            return new DoTransRequest(new DoTransRequestBody(request.code, jsonString));
        }
    }

    public class HisDoTransResponse<TData>
    {
        public string result { get; set; }

        public string message { get; set; }

        public TData data { get; set; }

        public string funName { get; set; }

        public string outString { get; set; }
    }

    public class HisShemaInfo
    {
        public string ID { get; set; }

        public string SEE_DATE { get; set; }

        public string WEEK { get; set; }

        public string NOONCODE { get; set; }

        public string BEGIN_TIME { get; set; }

        public string END_TIME { get; set; }

        public string DEPT_CODE { get; set; }

        public string DEPT_NAME { get; set; }

        public string DOCT_CODE { get; set; }

        public string DOCT_NAME { get; set; }

        public string REG_LMT { get; set; }

        public string REG_REGED { get; set; }

        public string REGLEVL_NAME { get; set; }

        public string TOT_COST { get; set; }

        public string ADRESS { get; set; }

        public string REGISTRATION_TYPE { get; set; }
    }
}
