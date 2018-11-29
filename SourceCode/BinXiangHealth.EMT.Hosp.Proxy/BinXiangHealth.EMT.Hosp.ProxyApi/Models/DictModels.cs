namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models
{
    /// <summary>
    /// dict query request
    /// </summary>
    /// <seealse cref="HOSP.JHWR.Hosp0000Request"/>
    public class DictQueryRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// key
        /// </summary>
        /// <value>EMPLOYEE|DEPARTMENT|REGLEVEL|PACTUNITINFO|NOON|PAYKIND</value>
        public string key { get; set; } = string.Empty;

        /// <summary>
        /// code
        /// </summary>
        /// <value></value>
        public string code { get; set; } = string.Empty;
    }

    /// <summary>
    /// dict query response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp0000ResponseData"/>
    public class DictQueryResponse : IProxyResponseModel
    {
        /// <summary>
        /// code
        /// </summary>
        /// <value></value>
        public string code { get; set; } = string.Empty;

        /// <summary>
        /// name
        /// </summary>
        /// <value></value>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// desc
        /// </summary>
        /// <value></value>
        public string desc { get; set; } = string.Empty;
    }

    /*
    /// <summary>
    /// card query request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp1002Request"/>
    public class CardQueryRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// String	否	就诊人姓名
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// String	否	就诊人身份证
        /// </summary>
        public string idCard { get; set; } = string.Empty;

        /// <summary>
        /// String	否	建档卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        /// String	否	建档卡号类型 5身份证 6医保卡  7银行卡
        /// </summary>
        public string cardType { get; set; } = string.Empty;

        /// <summary>
        /// String	是	查询方式 0 自费患者查询  姓名和身份证  1 物理卡号查询
        /// </summary>
        public string queryType { get; set; } = string.Empty;
    }

    /// <summary>
    /// card query response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp1002ResponseData"/>
    public class CardQueryResponse : IProxyResponseModel
    {
        /// <summary>
        /// 0000096874
        /// </summary>
        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        /// 毛萍
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// Vacancy
        /// </summary>
        public string vacancy { get; set; } = string.Empty;

        /// <summary>
        /// 女
        /// </summary>
        public string sex { get; set; } = string.Empty;

        /// <summary>
        /// 1988-07-09
        /// </summary>
        public string birthday { get; set; } = string.Empty;

        /// <summary>
        /// Linkman_name
        /// </summary>
        public string linkmanName { get; set; } = string.Empty;

        /// <summary>
        /// Linkman_add
        /// </summary>
        public string linkmanAdd { get; set; } = string.Empty;

        /// <summary>
        /// Linkman_tel
        /// </summary>
        public string linkmanTel { get; set; } = string.Empty;

        /// <summary>
        /// PactCode
        /// </summary>
        public string pactCode { get; set; } = string.Empty;
    }
    */
}
