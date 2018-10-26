
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 挂号缴费记录
    /// </summary>
    public class RegisterFeeHistoryRequest : BaseApiRequest
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
}
