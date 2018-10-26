
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 挂号缴费记录请求参数
    /// </summary>
    public class FeeRegisterQueryRequest : BaseApiRequest
    {
        /// <summary>
        /// 合同单位
        /// </summary>
        public string pactCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(pactCode))
            {
                message = ErrorMessage(() => pactCode);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 挂号缴费记录
    /// </summary>
    public class FeeRegisterQueryData
    {
        /// <summary>
        /// 唯一号
        /// </summary>
        public string recipeId { get; set; }

        /// <summary>
        /// 处方号
        /// </summary>
        public string recipeNo { get; set; }

        /// <summary>
        /// 处方内序号
        /// </summary>
        public string seqNo { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string transType { get; set; }

        /// <summary>
        /// 最小费用代码
        /// </summary>
        public string feeCode { get; set; }

        /// <summary>
        /// 是否是药品
        /// </summary>
        public string drugFlag { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string itemCode { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 医保项目相关参数 多个#分隔
        /// </summary>
        public string ybItemInfo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string qty { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public string unitPrice { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// 总额
        /// </summary>
        public string totCost { get; set; }

        /// <summary>
        /// 开方医生
        /// </summary>
        public string doctName { get; set; }

        /// <summary>
        /// 开方医生所在科室
        /// </summary>
        public string doctDeptName { get; set; }

        /// <summary>
        /// 执行科室
        /// </summary>
        public string execDeptCode { get; set; }

        /// <summary>
        /// 执行科室名称
        /// </summary>
        public string execDeptName { get; set; }

        /// <summary>
        /// 开立时间
        /// </summary>
        public string moDate { get; set; }

        /// <summary>
        /// 是否收费
        /// </summary>
        public string payFlag { get; set; }

        /// <summary>
        /// 发票号
        /// </summary>
        public string invoiceNo { get; set; }
    }
}
