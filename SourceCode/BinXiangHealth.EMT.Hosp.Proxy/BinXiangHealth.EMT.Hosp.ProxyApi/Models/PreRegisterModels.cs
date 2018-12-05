﻿namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models
{
    /// <summary>
    /// pre register do request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2011Request"/>
    public class PreRegisterDoRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string id { get; set; } = string.Empty;

        /// <summary>
        /// 合同单位编码
        /// </summary>
        public string pactCode { get; set; } = string.Empty;
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
        public string id { get; set; } = string.Empty;

        /// <summary>
        /// HIS 交易发票号
        /// </summary>
        public string tradeNo { get; set; } = string.Empty;
        
        /// <summary>
        /// 看诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;
        
        /// <summary>
        /// 科室地址
        /// </summary>
        public string address { get; set; } = string.Empty;
        
        /// <summary>
        /// 科室
        /// </summary>
        public string deptname { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre register cancel request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2007Request"/>
    public class PreRegisterCancelRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string id { get; set; } = string.Empty;
    }

    /// <summary>
    /// pre register cancel response
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
        /// 排班编号
        /// </summary>
        public string id { get; set; } = string.Empty;

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// 10位就诊卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        /// 预约时间 yyyy-MM-ddHH:mm:ss
        /// </summary>
        public string time { get; set; } = string.Empty;
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
        /// HIS 交易发票号
        /// </summary>
        public string tradeNo { get; set; } = string.Empty;
    }

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
}
