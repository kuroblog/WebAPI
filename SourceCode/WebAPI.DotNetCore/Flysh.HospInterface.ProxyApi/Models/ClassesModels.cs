
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Gboxt.Common.DataModel;
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// property helper class
    /// </summary>
    public static class PropertySupport
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyExpression"></param>
        /// <returns></returns>
        public static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
                throw new ArgumentNullException(nameof(propertyExpression));

            return ExtractPropertyNameFromLambda(propertyExpression);
        }

        internal static string ExtractPropertyNameFromLambda(LambdaExpression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException($"{nameof(expression)} is null.");

            var property = memberExpression.Member as PropertyInfo;
            if (property == null)
                throw new ArgumentException($"{nameof(expression)} is null.");

            var getMethod = property.GetMethod;
            if (getMethod.IsStatic)
                throw new ArgumentException($"{nameof(expression)} is static.");

            return memberExpression.Member.Name;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseApiRequest : IApiArgument
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public virtual bool Validate(out string message)
        {
            message = string.Empty;
            return string.IsNullOrEmpty(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="propertyExpression"></param>
        /// <param name="errorMessageForamt"></param>
        /// <returns></returns>
        public virtual string ErrorMessage<TProperty>(Expression<Func<TProperty>> propertyExpression, string errorMessageForamt = "the property named {0} is null.")
        {
            var propertyName = PropertySupport.ExtractPropertyName(propertyExpression);

            return string.Format(errorMessageForamt, propertyName);
        }
    }

    /// <summary>
    /// 排班信息请求参数
    /// </summary>
    public class ClassesScheduleRequest : BaseApiRequest
    {
        /// <summary>
        /// 开始时间(yyyy-MM-dd)
        /// </summary>
        public string beginDate { get; set; } = string.Empty;

        /// <summary>
        /// 结束时间(yyyy-MM-dd)
        /// </summary>
        public string endDate { get; set; } = string.Empty;

        /// <summary>
        /// 科室编码
        /// </summary>
        public string deptCode { get; set; } = string.Empty;

        /// <summary>
        /// 是否预约(0 不预约 or 1 预约)
        /// </summary>
        public string isPre { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(beginDate))
            {
                message = ErrorMessage(() => beginDate);
            }
            else if (string.IsNullOrEmpty(endDate))
            {
                message = ErrorMessage(() => endDate);
            }
            else if (string.IsNullOrEmpty(isPre))
            {
                message = ErrorMessage(() => isPre);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 排班信息
    /// </summary>
    public class ClassesScheduleData
    {
        /// <summary>
        /// 排班 ID
        /// </summary>
        public string classId { get; set; }

        /// <summary>
        /// 看诊时间
        /// </summary>
        public string seeDate { get; set; }

        /// <summary>
        /// 星期几
        /// </summary>
        public string week { get; set; }

        /// <summary>
        /// 午别
        /// </summary>
        public string nooncode { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string beginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// 科室编码
        /// </summary>
        public string deptCode { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string deptName { get; set; }

        /// <summary>
        /// 医生编码
        /// </summary>
        public string doctCode { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string doctName { get; set; }

        /// <summary>
        /// 预约总数
        /// </summary>
        public string regLmt { get; set; }

        /// <summary>
        /// 已经预约数
        /// </summary>
        public string regReged { get; set; }

        /// <summary>
        /// 挂号等级
        /// </summary>
        public string regLevl { get; set; }

        /// <summary>
        /// 挂号金额
        /// </summary>
        public string totCost { get; set; }

        /// <summary>
        /// 科室地址
        /// </summary>
        public string adress { get; set; }

        /// <summary>
        /// 挂号类别(0 普通号(PT) or 1 专家号(ZJ))
        /// </summary>
        public string regType { get; set; }
    }

    /// <summary>
    /// 可预约时间点信息请求参数
    /// </summary>
    public class ClassesPointRequest : BaseApiRequest
    {
        /// <summary>
        /// 排班编号（his主键）
        /// </summary>
        public string classId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(classId))
            {
                message = ErrorMessage(() => classId);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 预约信息请求参数
    /// </summary>
    public class ClassesSubscribeRequest : BaseApiRequest
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
    public class ClassesSubscribeData
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
    /// 预约取消
    /// </summary>
    public class ClassesSubscribeCancelRequest : BaseApiRequest
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
    /// 预约查询
    /// </summary>
    public class ClassesSubscribeQueryRequest : BaseApiRequest
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
    public class ClassesSubscribeQueryData
    {

    }
}
