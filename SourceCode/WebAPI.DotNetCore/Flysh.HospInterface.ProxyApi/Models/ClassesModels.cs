
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 排班信息 request [2003]
    /// </summary>
    public class ClassScheduleRequest : ApiRequestBase
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
    public class ClassScheduleData
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

        /// <summary>
        /// HIS项目编码(根据此字段1005查询医保中心对应的项目编码和医院的自付比率)
        /// </summary>
        public string itemCode { get; set; }

        /// <summary>
        /// 排序ID
        /// </summary>
        public string sortId { get; set; }

        /// <summary>
        /// 剩余挂号数
        /// </summary>
        public string hasReg { get; set; }
    }

    /// <summary>
    /// 可预约时间点信息 request [2004]
    /// </summary>
    public class ClassPointRequest : ApiRequestBase
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
}
