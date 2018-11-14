namespace Flysh.Hosp.ProxyApi.Models
{
    /// <summary>
    /// register query request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.HospRegisterQueryRequest"/>
    public class RegisterQueryRequest : ProxyRequestModelBase, IProxyRequestModel
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
    /// register query response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.HospRegisterQueryResponseData"/>
    public class RegisterQueryResponse : IProxyResponseModel
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
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// register do request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp3004Request"/>
    public class RegisterDoRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 是	排班编号（可为空）专家号必填
        /// </summary>
        public string id { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人真实姓名
        /// </summary>
        public string name { get; set; } = string.Empty;

        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        /// 挂号科室名称
        /// </summary>
        public string deptName { get; set; } = string.Empty;

        /// <summary>
        /// 挂号科室编号
        /// </summary>
        public string deptCode { get; set; } = string.Empty;

        /// <summary>
        /// 医生名称
        /// </summary>
        public string doctName { get; set; } = string.Empty;

        /// <summary>
        /// 医生编号
        /// </summary>
        public string doctCode { get; set; } = string.Empty;

        /// <summary>
        /// 挂号级别
        /// </summary>
        public string regCode { get; set; } = string.Empty;

        /// <summary>
        /// 挂号午别
        /// </summary>
        public string regNoonCode { get; set; } = string.Empty;

        /// <summary>
        /// 门诊类型  PT 普通门诊  ZJ 专家门诊
        /// </summary>
        public string regType { get; set; } = string.Empty;

        /// <summary>
        /// 挂号日期 yyyy-MM-dd
        /// </summary>
        public string regDate { get; set; } = string.Empty;

        /// <summary>
        /// 挂号时间段 08:00 如果挂号不到时间点 默认为空
        /// </summary>
        public string regTime { get; set; } = string.Empty;

        /// <summary>
        /// 挂号费用（单位:元）
        /// </summary>
        public string cost { get; set; } = string.Empty;

        /// <summary>
        /// 自费医保病人标识
        /// </summary>
        public string pactCode { get; set; } = string.Empty;

        /// <summary>
        /// 自助机机器编号
        /// </summary>
        public string termId { get; set; } = string.Empty;

        /// <summary>
        /// 操作员工号
        /// </summary>
        public string operCode { get; set; } = string.Empty;

        /// <summary>
        /// 是否支付 0未支付 1账户支付 2已经支付
        /// </summary>
        public string isFee { get; set; } = string.Empty;
    }

    /// <summary>
    /// register do response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp3004ResponseData"/>
    public class RegisterDoResponse : IProxyResponseModel
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;
    }

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
