namespace Flysh.Hosp.ProxyApi.Models
{
    public class RegisterCancelRequestModel : ProxyRequestModelBase, IProxyRequestModel
    {
        public string clinicNo { get; set; } = string.Empty;

        public string operCode { get; set; } = string.Empty;
    }

    public class RegisterCancelResponseModel : IProxyResponseModel
    {
        public int state { get; set; } = 0;
    }
}
