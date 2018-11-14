namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models
{
    /// <summary>
    /// cost pre request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp4003Request"/>
    public class CostPreRequest : ProxyRequestModelBase, IProxyRequestModel
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
    public class CostPreResponse : IProxyResponseModel
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
