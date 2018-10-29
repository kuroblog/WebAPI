
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 预约信息 request [2008]
    /// </summary>
    public class SubscribeSubmitRequest : ApiRequestBase
    {
        /// <summary>
        /// 排班编号/专家挂号必填
        /// </summary>
        public string classId { get; set; }

        /// <summary>
        /// 患者卡号
        /// </summary>
        public string cardNo { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 是否专家挂号(1 专家 or 0 不是专家)
        /// </summary>
        public string isExpert { get; set; }

        /// <summary>
        /// 科室代码/不是专家必填
        /// </summary>
        public string deptCode { get; set; }

        /// <summary>
        /// 预约时间 yyyy-MM-ddHH:mi:ss
        /// </summary>
        public string preTime { get; set; }

        /// <summary>
        /// 是否支付 0 未支付 or 1 账户支付 or 2 已经支付
        /// </summary>
        public string isFee { get; set; }

        /// <summary>
        /// 总费用
        /// </summary>
        public string clinicFee { get; set; }

        /// <summary>
        /// 预约来源 标识厂商
        /// </summary>
        public string subSource { get; set; }

        /// <summary>
        /// 1 预约挂号取号 or 2 预约挂号直接就诊
        /// </summary>
        public string subType { get; set; }

        /// <summary>
        /// 支付方式 CA 现金 or ZB 支付宝 or WX 微信
        /// </summary>
        public string feeSource { get; set; }

        /// <summary>
        /// 第三方订单流水号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 取号验证码
        /// </summary>
        public string identifyCode { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string operCode { get; set; }

        /// <summary>
        /// 自助机终端号
        /// </summary>
        public string termId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(cardNo))
            {
                message = ErrorMessage(() => cardNo);
            }
            else if (string.IsNullOrEmpty(realName))
            {
                message = ErrorMessage(() => realName);
            }
            else if (string.IsNullOrEmpty(isExpert))
            {
                message = ErrorMessage(() => isExpert);
            }
            else if (string.IsNullOrEmpty(preTime))
            {
                message = ErrorMessage(() => preTime);
            }
            else if (string.IsNullOrEmpty(isFee))
            {
                message = ErrorMessage(() => isFee);
            }
            else if (string.IsNullOrEmpty(clinicFee))
            {
                message = ErrorMessage(() => clinicFee);
            }
            else if (string.IsNullOrEmpty(subSource))
            {
                message = ErrorMessage(() => subSource);
            }
            else if (string.IsNullOrEmpty(subType))
            {
                message = ErrorMessage(() => subType);
            }
            else if (string.IsNullOrEmpty(feeSource))
            {
                message = ErrorMessage(() => feeSource);
            }
            else if (string.IsNullOrEmpty(tradeNo))
            {
                message = ErrorMessage(() => tradeNo);
            }
            else if (string.IsNullOrEmpty(identifyCode))
            {
                message = ErrorMessage(() => identifyCode);
            }
            else if (string.IsNullOrEmpty(operCode))
            {
                message = ErrorMessage(() => operCode);
            }
            else if (string.IsNullOrEmpty(termId))
            {
                message = ErrorMessage(() => termId);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 预约信息
    /// </summary>
    public class SubscribeSubmitData
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string subscribeId { get; set; }

        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string seeNo { get; set; }
    }

    /// <summary>
    /// 预约取消 request [2007]
    /// </summary>
    public class SubscribeCancelRequest : ApiRequestBase
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string subscribeId { get; set; }

        /// <summary>
        /// 操作员
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

            if (string.IsNullOrEmpty(subscribeId))
            {
                message = ErrorMessage(() => subscribeId);
            }
            else if (string.IsNullOrEmpty(operCode))
            {
                message = ErrorMessage(() => operCode);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 预约查询 request [2005]
    /// </summary>
    public class SubscribeQueryRequest : ApiRequestBase
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string subscribeId { get; set; }

        /// <summary>
        /// 患者卡号
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

            if (string.IsNullOrEmpty(subscribeId))
            {
                message = ErrorMessage(() => subscribeId);
            }
            else if (string.IsNullOrEmpty(cardNo))
            {
                message = ErrorMessage(() => cardNo);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 预约查询
    /// </summary>
    public class SubscribeQueryData
    {
        /// <summary>
        /// 状态：预约 or 取消预约 or 预约转挂号
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 科室信息
        /// </summary>
        public string deptName { get; set; }
    }
}
