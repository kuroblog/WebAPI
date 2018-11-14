namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models
{
    /// <summary>
    /// schedule query request
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2003Request"/>
    public class ScheduleQueryRequest : ProxyRequestModelBase, IProxyRequestModel
    {
        /// <summary>
        /// 开始时间 yyyy-MM-dd
        /// </summary>
        public string begDate { get; set; } = string.Empty;

        /// <summary>
        /// 结束时间 yyyy-MM-dd
        /// </summary>
        public string endDate { get; set; } = string.Empty;

        /// <summary>
        /// 科室编码
        /// </summary>
        public string deptCode { get; set; } = string.Empty;

        /// <summary>
        /// 是否预约 0 不预约 1 预约
        /// </summary>
        public string isPre { get; set; } = string.Empty;
    }

    /// <summary>
    /// schedule query response
    /// </summary>
    /// <seealso cref="HOSP.JHWR.Hosp2003ResponseData"/>
    public class ScheduleQueryResponse : IProxyResponseModel
    {
        /// <summary>
        /// string	是	排班ID
        /// </summary>
        public string id { get; set; } = string.Empty;

        /// <summary>
        /// string	否	看诊时间 
        /// </summary>
        public string date { get; set; } = string.Empty;

        /// <summary>
        /// string	是	星期几
        /// </summary>
        public string week { get; set; } = string.Empty;

        /// <summary>
        /// string	是	午别
        /// </summary>
        public string noonCode { get; set; } = string.Empty;

        /// <summary>
        /// 午别名称
        /// </summary>
        public string noonName { get; set; } = string.Empty;

        /// <summary>
        /// string	是	开始时间
        /// </summary>
        public string begTime { get; set; } = string.Empty;

        /// <summary>
        /// string	是	结束时间
        /// </summary>
        public string endTime { get; set; } = string.Empty;

        /// <summary>
        /// string	是	科室编码
        /// </summary>
        public string deptCode { get; set; } = string.Empty;

        /// <summary>
        /// string	否	科室名称
        /// </summary>
        public string deptName { get; set; } = string.Empty;

        /// <summary>
        /// string	否	医生编码
        /// </summary>
        public string doctCode { get; set; } = string.Empty;

        /// <summary>
        /// //string	是	医生名称
        /// </summary>
        public string doctName { get; set; } = string.Empty;

        /// <summary>
        /// string	是	预约总数
        /// </summary>
        //public string REG_LMT { get; set; }

        public string limit { get; set; } = string.Empty;

        /// <summary>
        /// string	是	已经预约数
        /// </summary>
        // public string REG_REGED { get; set; }
        public string registered { get; set; } = string.Empty;

        /// <summary>
        /// 挂号等级代码
        /// </summary>
        public string regCode { get; set; } = string.Empty;

        /// <summary>
        /// string	是	挂号等级
        /// </summary>
        public string regName { get; set; } = string.Empty;

        /// <summary>
        /// string	是	挂号金额
        /// </summary>
        public string regCost { get; set; } = string.Empty;

        /// <summary>
        /// string	是	科室地址
        /// </summary>
        public string address { get; set; } = string.Empty;

        /// <summary>
        /// string	是	0(PT) 普通号 1(ZJ) 专家号
        /// </summary>
        public string regType { get; set; } = string.Empty;

        /// <summary>
        /// HIS项目编码(根据此字段1005查询医保中心对应的项目编码和医院的自付比率)
        /// </summary>
        public string costCode { get; set; } = string.Empty;

        /// <summary>
        /// 排序ID
        /// </summary>
        public string sortId { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string deptDesc { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string doctDesc { get; set; } = string.Empty;
    }
}
