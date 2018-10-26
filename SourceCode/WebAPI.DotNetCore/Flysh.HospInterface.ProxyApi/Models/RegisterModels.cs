
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 挂号信息请求参数
    /// </summary>
    public class RegisterSubmitRequest : BaseApiRequest
    {
        /// <summary>
        /// 排班编号（可为空）专家号必填
        /// </summary>
        public string classId { get; set; }

        /// <summary>
        /// 就诊人真实姓名
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string cardNo { get; set; }

        /// <summary>
        /// 挂号科室名称
        /// </summary>
        public string deptName { get; set; }

        /// <summary>
        /// 挂号科室编号
        /// </summary>
        public string deptCode { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string doctName { get; set; }

        /// <summary>
        /// 医生编号
        /// </summary>
        public string doctCode { get; set; }

        /// <summary>
        /// 挂号级别
        /// </summary>
        public string regLevel { get; set; }

        /// <summary>
        /// 挂号午别
        /// </summary>
        public string noonCode { get; set; }

        /// <summary>
        /// 门诊类型 PT 普通门诊 ZJ 专家门诊
        /// </summary>
        public string regType { get; set; }

        /// <summary>
        /// 挂号日期 yyyy-MM-dd
        /// </summary>
        public string regDate { get; set; }

        /// <summary>
        /// 挂号时间段 08:00 如果挂号不到时间点 默认为空
        /// </summary>
        public string regTime { get; set; }

        /// <summary>
        /// 挂号费用（单位:元）
        /// </summary>
        public string clinicFee { get; set; }

        /// <summary>
        /// 自费医保病人标识
        /// </summary>
        public string pactCode { get; set; }

        /// <summary>
        /// 自助机机器编号
        /// </summary>
        public string termId { get; set; }

        /// <summary>
        /// 操作员工号
        /// </summary>
        public string operCode { get; set; }

        /// <summary>
        /// 是否支付 0未支付 1账户支付 2已经支付
        /// </summary>
        public string isFee { get; set; }

        /// <summary>
        /// 支付方式 （支付必填）ZB 支付宝 WX 微信 CA 现金 CD 银行卡
        /// </summary>
        public string feeSource { get; set; }

        /// <summary>
        /// 支付流水号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 医保结算参数 多个#分隔
        /// </summary>
        public string siInfo { get; set; }

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
            else if (string.IsNullOrEmpty(deptCode))
            {
                message = ErrorMessage(() => deptCode);
            }
            else if (string.IsNullOrEmpty(doctCode))
            {
                message = ErrorMessage(() => doctCode);
            }
            else if (string.IsNullOrEmpty(regLevel))
            {
                message = ErrorMessage(() => regLevel);
            }
            else if (string.IsNullOrEmpty(noonCode))
            {
                message = ErrorMessage(() => noonCode);
            }
            else if (string.IsNullOrEmpty(regType))
            {
                message = ErrorMessage(() => regType);
            }
            else if (string.IsNullOrEmpty(regDate))
            {
                message = ErrorMessage(() => regDate);
            }
            else if (string.IsNullOrEmpty(pactCode))
            {
                message = ErrorMessage(() => pactCode);
            }
            else if (string.IsNullOrEmpty(termId))
            {
                message = ErrorMessage(() => termId);
            }
            else if (string.IsNullOrEmpty(operCode))
            {
                message = ErrorMessage(() => operCode);
            }
            else if (string.IsNullOrEmpty(isFee))
            {
                message = ErrorMessage(() => isFee);
            }
            else if (string.IsNullOrEmpty(feeSource))
            {
                message = ErrorMessage(() => feeSource);
            }
            else if (string.IsNullOrEmpty(tradeNo))
            {
                message = ErrorMessage(() => tradeNo);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 挂号信息
    /// </summary>
    public class RegisterSubmitData
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; }

        /// <summary>
        /// HIS交易发票号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string seeNo { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string registerId { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string registerHisId { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string vancy { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string deptName { get; set; }
    }

    /// <summary>
    /// 取消挂号请求参数
    /// </summary>
    public class RegisterCancelRequest : BaseApiRequest
    {
        /// <summary>
        /// 挂号唯一号（his）
        /// </summary>
        public string clinicNo { get; set; }

        /// <summary>
        /// 操作员工号
        /// </summary>
        public string operCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(clinicNo))
            {
                message = ErrorMessage(() => clinicNo);
            }
            else if (string.IsNullOrEmpty(operCode))
            {
                message = ErrorMessage(() => operCode);
            }

            return string.IsNullOrEmpty(message);
        }
    }
}
