
namespace Flysh.HospInterface.ProxyApi.His
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using JHWR;
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public static class HisDoTransRequestExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="IHospRequest"></typeparam>
        /// <typeparam name="TData"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DoTransRequest GetRequestData<IHospRequest, TData>(this IHospRequest request)
            where IHospRequest : HospRequest<TData>
        {
            var jsonString = request.data == null ? string.Empty : request.data.GetType() == typeof(string) ? $"{request.data}" : JsonConvert.SerializeObject(request.data);

            return new DoTransRequest(new DoTransRequestBody(request.code, jsonString));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string message { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class HisDataResponse<TData> : HisResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual TData data { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class HisDataResponse2<TData> : HisDataResponse<TData>
    {
        //public string result { get; set; }

        //public string message { get; set; }

        //public TData data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string funName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string outString { get; set; }
    }

    /// <summary>
    /// 可预约时间点信息 result [2004]
    /// </summary>
    public class HisShemaPointResponse : HisResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        public string timeinfo { get; set; }
    }

    /// <summary>
    /// 预约查询 result [2005]
    /// </summary>
    public class HisBookingInfoResponse : HisResponseBase
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

    /// <summary>
    /// 排班信息 result [2003]
    /// </summary>
    public class HisShemaInfo
    {
        /// <summary>
        /// 排班ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 看诊时间
        /// </summary>
        public string SEE_DATE { get; set; }

        /// <summary>
        /// 星期几
        /// </summary>
        public string WEEK { get; set; }

        /// <summary>
        /// 午别
        /// </summary>
        public string NOONCODE { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string BEGIN_TIME { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string END_TIME { get; set; }

        /// <summary>
        /// 科室编码
        /// </summary>
        public string DEPT_CODE { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string DEPT_NAME { get; set; }

        /// <summary>
        /// 医生编码
        /// </summary>
        public string DOCT_CODE { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DOCT_NAME { get; set; }

        /// <summary>
        /// 预约总数 REG_LMT
        /// </summary>
        public string BOOKING_LMT { get; set; }

        /// <summary>
        /// 已经预约数 REG_REGED
        /// </summary>
        public string TEL_REGED { get; set; }

        /// <summary>
        /// 挂号等级代码
        /// </summary>
        public string REGLEVL_CODE { get; set; }

        /// <summary>
        /// 挂号等级
        /// </summary>
        public string REGLEVL_NAME { get; set; }

        /// <summary>
        /// 挂号金额
        /// </summary>
        public string TOT_COST { get; set; }

        /// <summary>
        /// 科室地址
        /// </summary>
        public string ADRESS { get; set; }

        /// <summary>
        /// 0 普通号(PT) 1 专家号(ZJ)
        /// </summary>
        public string REGISTRATION_TYPE { get; set; }

        /// <summary>
        /// HIS项目编码(根据此字段1005查询医保中心对应的项目编码和医院的自付比率)
        /// </summary>
        public string ITEMCODE { get; set; }

        /// <summary>
        /// 排序ID
        /// </summary>
        public string SORTID { get; set; }

        /// <summary>
        /// 剩余挂号数
        /// </summary>
        public string HASREG { get; set; }
    }

    /// <summary>
    /// 预约挂号 result [2008]
    /// </summary>
    public class HisSaveBookingInfo
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string bookingNo { get; set; }

        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; }

        /// <summary>
        /// 就诊序号
        /// </summary>
        public string seeNo { get; set; }
    }

    /// <summary>
    /// 挂号 result [3004]
    /// </summary>
    public class HisRegisterInfo
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        //public string clinicNo { get; set; }

        /// <summary>
        /// 就诊序号
        /// </summary>
        public string seeNo { get; set; }

        /// <summary>
        /// HIS交易发票号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string registerId { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string hisRegisterId { get; set; }

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
    /// 挂号缴费列表 result [3006]
    /// </summary>
    public class HisFeeRecInfo
    {
        /// <summary>
        /// 唯一号
        /// </summary>
        public string Recipe_Key { get; set; }

        /// <summary>
        /// 处方号
        /// </summary>
        public string Recipe_No { get; set; }

        /// <summary>
        /// 处方内序号
        /// </summary>
        public string SeqNo { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string Trans_Type { get; set; }

        /// <summary>
        /// 最小费用代码
        /// </summary>
        public string Fee_Code { get; set; }

        /// <summary>
        /// 是否是药品
        /// </summary>
        public string Drug_Flag { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string Item_Code { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Item_Name { get; set; }

        /// <summary>
        /// 医保项目相关参数 多个#分隔
        /// </summary>
        public string Yb_Item_Info { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string Qty { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public string Unit_Price { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string UNIT { get; set; }

        /// <summary>
        /// 总额
        /// </summary>
        public string Tot_Cost { get; set; }

        /// <summary>
        /// 开方医生
        /// </summary>
        public string Doc_Name { get; set; }

        /// <summary>
        /// 开方医生所在科室
        /// </summary>
        public string DocDept_Name { get; set; }

        /// <summary>
        /// 执行科室
        /// </summary>
        public string Exec_DeptCode { get; set; }

        /// <summary>
        /// 执行科室名称
        /// </summary>
        public string Exec_DeptName { get; set; }

        /// <summary>
        /// 开立时间
        /// </summary>
        public string Mo_Date { get; set; }

        /// <summary>
        /// 是否收费
        /// </summary>
        public string Pay_Flag { get; set; }

        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoiceNo { get; set; }
    }

    /// <summary>
    /// 查询检验、检查报告列表 result [5001]
    /// </summary>
    public class HisReportInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string queryId { get; set; }

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

    /// <summary>
    /// 病人挂号信息 result [4000]
    /// </summary>
    public class HisRegListInfo
    {
        /// <summary>
        /// String	是	患者姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// String	是	挂号时间
        /// </summary>
        public string Reg_Date { get; set; }

        /// <summary>
        /// String	是	挂号科室
        /// </summary>
        public string Dept_Name { get; set; }

        /// <summary>
        /// String	是	挂号医生
        /// </summary>
        public string Doct_Name { get; set; }

        /// <summary>
        /// String	是	未看诊 已看诊
        /// </summary>
        public string YnSee { get; set; }

        /// <summary>
        /// String	是	挂号流水号
        /// </summary>
        public string CLINIC_CODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HisRegItemInfo[] data { get; set; }

        /// <summary>
        /// 医保比例
        /// </summary>
        public string YBRate { get; set; }

        /// <summary>
        /// 医保中心代码
        /// </summary>
        public string YBCode { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisRegItemInfo
    {
        /// <summary>
        /// String	是	唯一号
        /// </summary>
        public string Recipe_Key { get; set; }

        ///String	是	处方号
        public string Recipe_No { get; set; }

        /// <summary>
        /// String	是	处方内序号
        /// </summary>
        public string SeqNo { get; set; }

        /// <summary>
        /// String	是	交易类型
        /// </summary>
        public string Trans_Type { get; set; }

        /// <summary>
        /// String	是	最小费用代码
        /// </summary>
        public string Fee_Code { get; set; }

        /// <summary>
        /// 	String	是	是否是药品
        /// </summary>
        public string Drug_Flag { get; set; }

        /// <summary>
        /// String	是	项目编码
        /// </summary>
        public string Item_Code { get; set; }

        /// <summary>
        ///String	是	项目名称
        /// </summary>
        public string Item_Name { get; set; }

        /// <summary>
        /// String	是	医保项目相关参数 多个#分隔
        /// </summary>
        public string Yb_Item_Info { get; set; }

        /// <summary>
        /// String	是	数量
        /// </summary>
        public string Qty { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 包装数量
        /// </summary>
        public string Pack_Qty { get; set; }

        /// <summary>
        /// 天数
        /// </summary>
        public string Days { get; set; }

        /// <summary>
        /// 复方标识
        /// </summary>
        public string Ff { get; set; }

        /// <summary>
        /// String	是	单价
        /// </summary>
        public string Unit_Price { get; set; }

        /// <summary>
        /// String	是	单位
        /// </summary>
        public string UNIT { get; set; }

        /// <summary>
        /// String	是	总额
        /// </summary>
        public string Tot_Cost { get; set; }

        /// <summary>
        /// String	是	开方医生
        /// </summary>
        public string Doc_Name { get; set; }

        /// <summary>
        /// 开单科室医生编号
        /// </summary>
        public string Doc_Code { get; set; }
        /// <summary>
        /// String	是	开方医生所在科室
        /// </summary>
        public string DocDept_Name { get; set; }

        /// <summary>
        /// String	是	执行科室
        /// </summary>
        public string Exec_DeptCode { get; set; }

        /// <summary>
        /// String	是	执行科室名称
        /// </summary>
        public string Exec_DeptName { get; set; }

        /// <summary>
        /// String	是	开立时间
        /// </summary>
        public string Mo_Date { get; set; }

        /// <summary>
        /// 	String	是	是否收费
        /// </summary>
        public string Pay_Flag { get; set; }

        /// <summary>
        /// String	是	发票号
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 挂号流水号
        /// </summary>
        public string CLINIC_CODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Dose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OnceDose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Frequency { get; set; }

        /// <summary>
        /// 分方
        /// </summary>
        public string recipeSeq { get; set; }

        /// <summary>
        /// 特慢病标识(0 普通 1特病  2 慢病)
        /// </summary>
        public string icdType { get; set; }

        /// <summary>
        /// 诊断编码
        /// </summary>
        public string icdCode { get; set; }

        /// <summary>
        /// 0  普通(不可报销)  1  可报销
        /// </summary>
        public string HasSaved { get; set; }

        /// <summary>
        /// 诊断名称
        /// </summary>
        public string icdName { get; set; }

        /// <summary>
        /// 物理卡号
        /// </summary>
        public string markno { get; set; }

        /// <summary>
        /// 病种审批单号
        /// </summary>
        public string proCode { get; set; }

        /// <summary>
        /// 值为PCC,是草药
        /// </summary>
        public string classCode { get; set; }
    }
}
