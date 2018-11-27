
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 卡号查询 request [1002]
    /// </summary>
    public class CardQueryRequest : ApiRequestBase
    {
        /// <summary>
        /// 就诊人姓名
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 就诊人身份证
        /// </summary>
        public string idCard { get; set; }

        /// <summary>
        /// 建档卡号
        /// </summary>
        public string mCardNo { get; set; }

        /// <summary>
        /// 建档卡号类型 5身份证 6医保卡  7银行卡
        /// </summary>
        public string mType { get; set; }

        /// <summary>
        /// 查询方式 0 自费患者查询  姓名和身份证  1 物理卡号查询
        /// </summary>
        public string queryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(queryType))
            {
                message = ErrorMessage(() => queryType);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 卡号信息
    /// </summary>
    public class CardQueryData
    {
        /// <summary>
        /// 0000096874
        /// </summary>
        public string cardNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Vacancy
        /// </summary>
        public string vacancy { get; set; }

        /// <summary>
        /// 女
        /// </summary>
        public string sex { get; set; }

        /// <summary>
        /// 1988-07-09
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        /// Linkman_name
        /// </summary>
        public string linkmanName { get; set; }

        /// <summary>
        /// Linkman_add
        /// </summary>
        public string linkmanAdd { get; set; }

        /// <summary>
        /// Linkman_tel
        /// </summary>
        public string linkmanTel { get; set; }

        /// <summary>
        /// BingliCost
        /// </summary>
        public string bingliCost { get; set; }

        /// <summary>
        /// PactCode
        /// </summary>
        public string pactCode { get; set; }

        /// <summary>
        /// 18869906650
        /// </summary>
        public string idno { get; set; }

        /// <summary>
        /// Idno2
        /// </summary>
        public string idno2 { get; set; }
    }
}
