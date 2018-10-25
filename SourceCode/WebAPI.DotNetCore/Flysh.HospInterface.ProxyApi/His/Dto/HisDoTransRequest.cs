
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
}
