namespace Flysh.Hosp.ProxyApi.Models
{
    /// <summary>
    /// register cancel request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp3005Response"/>
    public class RegisterCancelRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// String	是	挂号唯一号（his）
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// string	是	操作员工号
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    /// <summary>
    /// register cancel response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp3005ResponseData"/>
    public class RegisterCancelResponse : IProxyResponseModel
    {
        public int state { get; set; } = 0;
    }
}
