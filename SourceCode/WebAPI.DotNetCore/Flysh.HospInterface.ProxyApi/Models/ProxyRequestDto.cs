
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.His;
    using Gboxt.Common.DataModel;

    public class ProxyRequestDto<TData> : IApiArgument
    {
        public string code { get; set; }

        public TData data { get; set; }

        public bool Validate(out string message)
        {
            message = string.Empty;

            return true;
        }
    }

    public static class ProxyRequestDtoExtensions
    {
        public static DoTransRequestDto<TData> GetRequestData<TData>(this ProxyRequestDto<TData> dto)
        {
            return new DoTransRequestDto<TData>(dto.code, dto.data);
        }
    }
}
