
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Gboxt.Common.DataModel;

    #region ClassesSchedule
    /// <summary>
    /// 排班信息请求参数
    /// </summary>
    public class ClassesScheduleRequest : IApiArgument
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
        public bool Validate(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(beginDate))
            {
                message = nameof(beginDate) + " is null.";
            }

            if (string.IsNullOrEmpty(endDate))
            {
                message = nameof(endDate) + " is null.";
            }

            if (string.IsNullOrEmpty(isPre))
            {
                message = nameof(isPre) + " is null.";
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 排班信息
    /// </summary>
    public class ClassesScheduleResponse
    {
        /// <summary>
        /// 排班 ID
        /// </summary>
        public string id { get; set; }

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
    #endregion
}
