namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models
{
    /// <summary>
    /// cost list request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp4002Request"/>
    public class CostListRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// String	是	门诊挂号流水号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// String	否	就诊人卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// cost list response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp4002ResponseData"/>
    public class CostListResponse : IProxyResponseModel
    {
        /// <summary>
        /// String	是	唯一号
        /// </summary>
        public string recipeKey { get; set; }

        ///String	是	处方号
        public string recipeNo { get; set; }

        /// <summary>
        /// String	是	处方内序号
        /// </summary>
        public string seqNo { get; set; }

        /// <summary>
        /// String	是	交易类型
        /// </summary>
        public string transType { get; set; }

        /// <summary>
        /// String	是	最小费用代码
        /// </summary>
        public string costCode { get; set; }

        /// <summary>
        /// 	String	是	是否是药品
        /// </summary>
        public string drugFlag { get; set; }

        /// <summary>
        /// String	是	项目编码
        /// </summary>
        public string itemCode { get; set; }

        /// <summary>
        ///String	是	项目名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// String	是	医保项目相关参数 多个#分隔
        /// </summary>
        public string ybItemInfo { get; set; }

        /// <summary>
        /// String	是	数量
        /// </summary>
        public string qty { get; set; }

        /// <summary>
        /// String	是	单位
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// String	是	单价
        /// </summary>
        public string unitPrice { get; set; }

        /// <summary>
        /// String	是	总额
        /// </summary>
        public string totCost { get; set; }

        /// <summary>
        /// String	是	开方医生
        /// </summary>
        public string docName { get; set; }

        /// <summary>
        /// String	是	开方医生所在科室
        /// </summary>
        public string docDeptName { get; set; }

        /// <summary>
        /// String	是	执行科室
        /// </summary>
        public string execDeptCode { get; set; }

        /// <summary>
        /// String	是	执行科室名称
        /// </summary>
        public string execDeptName { get; set; }

        /// <summary>
        /// String	是	开立时间
        /// </summary>
        public string moDate { get; set; }

        /// <summary>
        /// 	String	是	是否收费
        /// </summary>
        public string payFlag { get; set; }
    }

    /// <summary>
    /// cost pre request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp4003Request"/>
    public class CostPreSettleRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// String 	是	唯一号 多个 | 分隔
        /// </summary>
        public string recipeKey { get; set; } = string.Empty;

        /// <summary>
        /// String	是	就诊人姓名
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// String	是	门诊流水号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// String	是	缴费操作员
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    /// <summary>
    /// cost pre response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp4003ResponseData"/>
    public class CostPreSettleResponse : IProxyResponseModel
    {
        /// <summary>
        /// String	是	总费用
        /// </summary>
        public string totCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	报销费用
        /// </summary>
        public string pubCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	个人卡内费用
        /// </summary>
        public string payCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	自费费用
        /// </summary>
        public string ownCost { get; set; } = string.Empty;
    }
}
