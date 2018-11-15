namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models
{
    /// <summary>
    /// register do request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.HospReportDetailRequest"/>
    public class ReportDetailRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; } = string.Empty;

        /// <summary>
        /// 1-检验 2-检查
        /// </summary>
        public string type { get; set; } = string.Empty;
    }

    /// <summary>
    /// register do response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.HospReportDetailResponseData"/>
    public class ReportDetailResponse : IProxyResponseModel
    {
        /// <summary>
        /// 报告名称
        /// </summary>
        public string itemName { get; set; } = string.Empty;

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; } = string.Empty;

        /// <summary>
        /// 检查日期
        /// </summary>
        public string date { get; set; } = string.Empty;

        /// <summary>
        /// 报告类型
        /// </summary>
        public string type { get; set; } = string.Empty;

        /// <summary>
        /// 样本
        /// </summary>
        public string sample { get; set; } = string.Empty;

        /// <summary>
        /// 实际值
        /// </summary>
        public string actual { get; set; } = string.Empty;

        /// <summary>
        /// 参考值
        /// </summary>
        public string reference { get; set; } = string.Empty;

        /// <summary>
        /// 结论
        /// </summary>
        public string conclusion { get; set; } = string.Empty;
    }
}
