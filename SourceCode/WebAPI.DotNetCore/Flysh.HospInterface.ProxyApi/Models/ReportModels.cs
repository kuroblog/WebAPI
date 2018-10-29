
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 报告列表查询参数 request [5001]
    /// </summary>
    public class ReportQueryRequest : ApiRequestBase
    {
        /// <summary>
        /// 就诊人姓名
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string cardNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(realName))
            {
                message = ErrorMessage(() => realName);
            }
            else if (string.IsNullOrEmpty(cardNo))
            {
                message = ErrorMessage(() => cardNo);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 报告列表信息
    /// </summary>
    public class ReportQueryData
    {
        /// <summary>
        /// key?
        /// </summary>
        public string reportId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 1-检验 2-检查
        /// </summary>
        public string checkType { get; set; }

        /// <summary>
        /// 0-检查中 1-检查完成
        /// </summary>
        public string status { get; set; }

    }
}
