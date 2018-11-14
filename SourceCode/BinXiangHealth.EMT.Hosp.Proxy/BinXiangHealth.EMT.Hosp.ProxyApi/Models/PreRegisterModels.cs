namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models
{
    /// <summary>
    /// pre register query request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.HospPreRegisterQueryRequest"/>
    public class PreRegisterQueryRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 开始时间yyyy-MM-dd
        /// </summary>
        public string begDate { get; set; } = string.Empty;

        /// <summary>
        /// 结束时间yyyy-MM-dd
        /// </summary>
        public string endDate { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre register query response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.HospPreRegisterQueryResponseData"/>
    public class PreRegisterQueryResponse : IProxyResponseModel
    {
        /// <summary>
        /// 状态：1预约2取消预约3预约转挂号
        /// </summary>
        public string state { get; set; } = string.Empty;

        /// <summary>
        /// 科室名称
        /// </summary>
        public string deptName { get; set; } = string.Empty;

        /// <summary>
        /// 预约类型/1、专家号/2、普通号
        /// </summary>
        public string regType { get; set; } = string.Empty;

        /// <summary>
        /// 预约日期
        /// </summary>
        public string visistDate { get; set; } = string.Empty;

        /// <summary>
        /// 预约时间段
        /// </summary>
        public string visitingTime { get; set; } = string.Empty;

        /// <summary>
        /// 医生姓名
        /// </summary>
        public string doctName { get; set; } = string.Empty;

        /// <summary>
        /// 医生职称
        /// </summary>
        public string doctTitle { get; set; } = string.Empty;

        /// <summary>
        /// 总费用
        /// </summary>
        public string cost { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// 提交时间
        /// </summary>
        public string regDate { get; set; } = string.Empty;

        /// <summary>
        /// 看诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;

        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string preNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre register do request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2011Request"/>
    public class PreRegisterDoRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string preNo { get; set; } = string.Empty;

        /// <summary>
        /// 挂号费用（单位:元）
        /// </summary>
        public string preCost { get; set; } = string.Empty;

        /// <summary>
        /// 自费医保病人标识
        /// </summary>
        public string pactCode { get; set; } = string.Empty;

        /// <summary>
        /// 支付方式 ZB 支付宝WX 微信CA 现金CD 银行卡
        /// </summary>
        public string source { get; set; } = string.Empty;

        /// <summary>
        /// 支付流水号
        /// </summary>
        public string tradeNo { get; set; } = string.Empty;

        /// <summary>
        /// 云端默认用户就诊卡号
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre register do response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2011ResponseData"/>
    public class PreRegisterDoResponse : IProxyResponseModel
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre cancel request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2007Request"/>
    public class PreRegisterCancelRequest : ProxyRequestModelBase, IProxyRequestModel
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
    public class PreRegisterCancelResponse : IProxyResponseModel
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
