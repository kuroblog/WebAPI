namespace Flysh.Hosp.ProxyApi.Models
{
    /// <summary>
    /// pre register request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2008Request"/>
    public class PreRegisterRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// String	否	排班编号 专家挂号必填
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 患者卡号
        /// </summary>
        public string cardNo { get; set; }

        /// <summary>
        ///患者姓名 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 是否专家挂号 1 专家  0 不是专家
        /// </summary>
        public string preType { get; set; }

        /// <summary>
        /// String	否	科室代码  不是专家必填
        /// </summary>
        public string deptCode { get; set; }

        /// <summary>
        /// 预约时间 yyyy-MM-ddHH:mi:ss
        /// </summary>
        public string preTime { get; set; }

        /// <summary>
        /// 是否支付 0 未支付 1 账户支付 2 已经支付
        /// </summary>
        public string isFee { get; set; }

        /// <summary>
        /// 总费用
        /// </summary>
        public string preCost { get; set; }

        /// <summary>
        /// 预约来源 标识厂商
        /// </summary>
        public string preSource { get; set; }
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
        public string preNo { get; set; }

        /// <summary>
        /// 就诊唯一号 
        /// </summary>
        public string clinicNo { get; set; }

        /// <summary>
        /// 就诊序号
        /// </summary>
        public string seeNo { get; set; }
    }
}
