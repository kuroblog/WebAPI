namespace Flysh.Hosp.ProxyApi.Models
{
    /// <summary>
    /// pre cancel request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2007Request"/>
    public class PreCancelRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// String	是	预约唯一号
        /// </summary>
        public string preNo { get; set; } = string.Empty;

        /// <summary>
        /// String	是	操作员
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre cancel response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2007Response"/>
    public class PreCancelResponse : IProxyResponseModel
    {
        public int state { get; set; } = 0;
    }

    /// <summary>
    /// pre register request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2008Request"/>
    public class PreRegisterRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// String	否	排班编号 专家挂号必填
        /// </summary>
        public string id { get; set; } = string.Empty;

        /// <summary>
        /// 患者卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        ///患者姓名 
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// 是否专家挂号 1 专家  0 不是专家
        /// </summary>
        public string preType { get; set; } = string.Empty;

        /// <summary>
        /// String	否	科室代码  不是专家必填
        /// </summary>
        public string deptCode { get; set; } = string.Empty;

        /// <summary>
        /// 预约时间 yyyy-MM-ddHH:mi:ss
        /// </summary>
        public string preTime { get; set; } = string.Empty;

        /// <summary>
        /// 是否支付 0 未支付 1 账户支付 2 已经支付
        /// </summary>
        public string isFee { get; set; } = string.Empty;

        /// <summary>
        /// 总费用
        /// </summary>
        public string preCost { get; set; } = string.Empty;

        /// <summary>
        /// 预约来源 标识厂商
        /// </summary>
        public string preSource { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre register response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2008ResponseData"/>
    public class PreRegisterResponse : IProxyResponseModel
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string preNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊唯一号 
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;
    }
}
