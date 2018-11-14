namespace Flysh.Hosp.ProxyApi.Models
{
    /// <summary>
    /// register callback request
    /// </summary>
    ///<seealso cref="HOSP.JHWR.HospRegCallbackRequest"/>
    public class RegisterCallbackRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// 支付流水号
        /// </summary>
        public string tradeNo { get; set; } = string.Empty;

        /// <summary>
        /// 第三方订单号
        /// </summary>
        public string thirdNo { get; set; } = string.Empty;

        /// <summary>
        /// 支付方式 (支付必填)ZB 支付宝 WX 微信 CA 现金 CD 银行卡
        /// </summary>
        public string source { get; set; } = string.Empty;

        /// <summary>
        /// 是否支付 0未支付 1账户支付 2已经支付
        /// </summary>
        public string isFee { get; set; } = string.Empty;

        /// <summary>
        /// 支付费用
        /// </summary>
        public string cost { get; set; } = string.Empty;

        /// <summary>
        /// 医保结算参数多个#分隔
        /// </summary>
        public string siInfo { get; set; } = string.Empty;
    }

    /// <summary>
    /// register callback response
    /// </summary>
    ///<seealso cref="HOSP.JHWR.HospRegCallbackResponseData"/>
    public class RegisterCallbackResponse : IProxyResponseModel
    {
        public int state { get; set; } = 0;
    }

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
