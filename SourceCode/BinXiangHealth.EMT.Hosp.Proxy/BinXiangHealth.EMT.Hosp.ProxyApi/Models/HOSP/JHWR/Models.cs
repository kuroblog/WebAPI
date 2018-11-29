using Newtonsoft.Json;
using System;
using System.Linq;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR
{
    public abstract class HospRequestModelBase : IHospProxyRequestModel//<(string code, string json)>
    {
        public virtual (string code, string json) ConvertToHospRequest()
        {
            var attr = GetType().GetCustomAttributes(typeof(HospTransferCodeAttribute), false).FirstOrDefault() as HospTransferCodeAttribute;
            var code = attr == null ? string.Empty : attr.TransferCode;
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return (code, json);
        }
    }

    public abstract class HospResponseModelBase<TData> : IHospProxyResponseModel
    {
        public virtual string result { get; set; } = string.Empty;

        public virtual string message { get; set; } = string.Empty;

        public virtual string funName { get; set; } = string.Empty;

        public virtual string outString { get; set; } = string.Empty;

        public virtual TData data { get; set; } = default(TData);

        public virtual bool IsSuccess => GetResponseCode() == 0;

        public virtual string GetResponseMessage()
        {
            return message;
        }

        public int GetResponseCode()
        {
            return string.Compare(result, "success", true);
        }
    }

    /// <summary>
    /// 检查报告入参
    /// </summary>
    public class HospReportQueryRequest : HospRequestModelBase
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string queryId { get; set; } = string.Empty;

        /// <summary>
        /// 1-检验 2-检查
        /// </summary>
        public string checkType { get; set; } = string.Empty;
    }

    public class HospReportQueryResponseData
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; } = string.Empty;

        /// <summary>
        /// 检查日期
        /// </summary>
        public string checkDate { get; set; } = string.Empty;

        /// <summary>
        /// 报告类型
        /// </summary>
        public string type { get; set; } = string.Empty;

        /// <summary>
        /// 检查所见
        /// </summary>
        public string reportMessage { get; set; } = string.Empty;

        /// <summary>
        /// 检查结论
        /// </summary>
        public string repostResult { get; set; } = string.Empty;
    }

    /// <summary>
    /// 检查报告返参
    /// </summary>
    public class HospReportQueryResponse : HospResponseModelBase<HospReportQueryResponseData> { }

    /// <summary>
    /// 检验报告详情入参
    /// </summary>
    public class HospReportDetailRequest : HospRequestModelBase
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string queryId { get; set; } = string.Empty;

        /// <summary>
        /// 1-检验 2-检查
        /// </summary>
        public string checkType { get; set; } = string.Empty;
    }

    public class HospReportDetailResponseData
    {
        /// <summary>
        /// 报告名称
        /// </summary>
        public string itemName { get; set; } = string.Empty;

        /// <summary>
        /// 姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; } = string.Empty;

        /// <summary>
        /// 检查日期
        /// </summary>
        public string checkDate { get; set; } = string.Empty;

        /// <summary>
        /// 报告类型
        /// </summary>
        public string type { get; set; } = string.Empty;

        /// <summary>
        /// 样本
        /// </summary>
        public string sample { get; set; } = string.Empty;

        /// <summary>
        /// 实际值
        /// </summary>
        public string realResult { get; set; } = string.Empty;

        /// <summary>
        /// 参考值
        /// </summary>
        public string referprint { get; set; } = string.Empty;

        /// <summary>
        /// 结论
        /// </summary>
        public string conclusion { get; set; } = string.Empty;
    }

    /// <summary>
    /// 检验报告详情返参
    /// </summary>
    public class HospReportDetailResponse : HospResponseModelBase<HospReportDetailResponseData[]> { }

    /// <summary>
    /// 挂号列表查询入参
    /// </summary>
    public class HospRegisterQueryRequest : HospRequestModelBase
    {
        /// <summary>
        /// 开始时间yyyy-MM-dd
        /// </summary>
        public string beginDate { get; set; } = string.Empty;

        /// <summary>
        /// 结束时间yyyy-MM-dd
        /// </summary>
        public string endDate { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;
    }

    public class HospRegisterQueryResponseData
    {
        /// <summary>
        /// 状态：1预约2取消预约3预约转挂号
        /// </summary>
        public string state { get; set; } = string.Empty;

        /// <summary>
        /// 科室名称
        /// </summary>
        public string deptName { get; set; } = string.Empty;

        /// <summary>
        /// 预约类型/1、专家号/2、普通号
        /// </summary>
        public string regType { get; set; } = string.Empty;

        /// <summary>
        /// 预约日期
        /// </summary>
        public string visistDate { get; set; } = string.Empty;

        /// <summary>
        /// 预约时间段
        /// </summary>
        public string visitingTime { get; set; } = string.Empty;

        /// <summary>
        /// 医生姓名
        /// </summary>
        public string doctName { get; set; } = string.Empty;

        /// <summary>
        /// 医生职称
        /// </summary>
        public string doctTitle { get; set; } = string.Empty;

        /// <summary>
        /// 总费用
        /// </summary>
        public string total { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string idCardNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        public string idCardName { get; set; } = string.Empty;

        /// <summary>
        /// 提交时间
        /// </summary>
        public string date { get; set; } = string.Empty;

        /// <summary>
        /// 看诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// 挂号列表查询返参
    /// </summary>
    public class HospRegisterQueryResponse : HospResponseModelBase<HospRegisterQueryResponseData[]> { }

    /// <summary>
    /// 预约挂号列表查询入参
    /// </summary>
    public class HospPreRegisterQueryRequest : HospRequestModelBase
    {
        /// <summary>
        /// 开始时间yyyy-MM-dd
        /// </summary>
        public string beginDate { get; set; } = string.Empty;

        /// <summary>
        /// 结束时间yyyy-MM-dd
        /// </summary>
        public string endDate { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;
    }

    public class HospPreRegisterQueryResponseData
    {
        /// <summary>
        /// 状态：1预约2取消预约3预约转挂号
        /// </summary>
        public string state { get; set; } = string.Empty;

        /// <summary>
        /// 科室名称
        /// </summary>
        public string deptName { get; set; } = string.Empty;

        /// <summary>
        /// 预约类型/1、专家号/2、普通号
        /// </summary>
        public string regType { get; set; } = string.Empty;

        /// <summary>
        /// 预约日期
        /// </summary>
        public string visistDate { get; set; } = string.Empty;

        /// <summary>
        /// 预约时间段
        /// </summary>
        public string visitingTime { get; set; } = string.Empty;

        /// <summary>
        /// 医生姓名
        /// </summary>
        public string doctName { get; set; } = string.Empty;

        /// <summary>
        /// 医生职称
        /// </summary>
        public string doctTitle { get; set; } = string.Empty;

        /// <summary>
        /// 总费用
        /// </summary>
        public string total { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string idCardNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        public string idCardName { get; set; } = string.Empty;

        /// <summary>
        /// 提交时间
        /// </summary>
        public string date { get; set; } = string.Empty;

        /// <summary>
        /// 看诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;

        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string bookingNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// 预约挂号列表查询返参
    /// </summary>
    public class HospPreRegisterQueryResponse : HospResponseModelBase<HospPreRegisterQueryResponseData[]> { }

    /// <summary>
    /// 0000 数据字典查询 入参
    /// </summary>
    public class Hosp0000Request : HospRequestModelBase
    {
        /// <summary>
        /// 字典类型
        /// </summary>
        /// <value>EMPLOYEE|DEPARTMENT|REGLEVEL|PACTUNITINFO|NOON|PAYKIND</value>
        public string dicType { get; set; } = string.Empty;

        /// <summary>
        /// 字典编码
        /// </summary>
        /// <value></value>
        public string dicCode { get; set; } = string.Empty;

        /// <summary>
        /// 字典类型为 EMPLOYEE 时使用
        /// </summary>
        /// <value>0 挂号|1 预约</value>
        public string isPre { get; set; } = string.Empty;

        /// <summary>
        /// 分院区
        /// </summary>
        /// <value>01 广州路|02 河西</value>
        public string branchcode { get; set; } = string.Empty;
    }

    /// <summary>
    /// 0000 data
    /// </summary>
    public class Hosp0000ResponseData
    {
        /// <summary>
        /// 编码
        /// </summary>
        /// <value></value>
        public string code { get; set; } = string.Empty;

        /// <summary>
        /// 名称
        /// </summary>
        /// <value></value>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// unknown
        /// </summary>
        /// <value></value>
        public string spellCode { get; set; } = string.Empty;

        /// <summary>
        /// unknown
        /// </summary>
        /// <value></value>
        public string wbCode { get; set; } = string.Empty;

        /// <summary>
        /// 备注
        /// </summary>
        /// <value></value>
        public string memo { get; set; } = string.Empty;
    }

    /// <summary>
    /// 0000 数据字典查询 返参
    /// </summary>
    public class Hosp0000Response : HospResponseModelBase<Hosp0000ResponseData[]> { }

    /// <summary>
    /// 5001 request
    /// </summary>
    public class Hosp5001Request : HospRequestModelBase
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string patientCard { get; set; } = string.Empty;

        /// <summary>
        /// 开始时间
        /// </summary>
        public string beginDate { get; set; } = string.Empty;

        /// <summary>
        /// 结束时间
        /// </summary>
        public string endDate { get; set; } = string.Empty;
    }

    public class Hosp5001ResponseData
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string queryId { get; set; } = string.Empty;

        /// <summary>
        /// 项目名称
        /// </summary>
        public string itemName { get; set; } = string.Empty;

        /// <summary>
        /// 姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// 1-检验 2-检查
        /// </summary>
        public string checkType { get; set; } = string.Empty;

        /// <summary>
        /// 0-检查中1-检查完成
        /// </summary>
        public string status { get; set; } = string.Empty;
    }

    /// <summary>
    /// 5001 response
    /// </summary>
    public class Hosp5001Response : HospResponseModelBase<Hosp5001ResponseData[]> { }

    /// <summary>
    /// 4004 request
    /// </summary>
    public class Hosp4004Request : HospRequestModelBase
    {
        /// <summary>
        /// String 	是	唯一号 多个 | 分隔
        /// </summary>
        public string recipe_Key { get; set; } = string.Empty;

        /// <summary>
        /// String	是	就诊人姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// String	是	门诊流水号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// String	是	缴费操作员
        /// </summary>
        public string operCode { get; set; } = string.Empty;

        /// <summary>
        /// String	是	支付方式
        /// </summary>
        public string feeSource { get; set; } = string.Empty;

        /// <summary>
        /// String	是	总费用
        /// </summary>
        public string totCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	报销费用
        /// </summary>
        public string pubCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	个人卡内费用
        /// </summary>
        public string payCost { get; set; } = string.Empty;

        /// <summary>
        /// }String	是	自费费用
        /// </summary>
        public string ownCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	交易流水号
        /// </summary>
        public string tradeNo { get; set; } = string.Empty;

        /// <summary>
        /// String	是	设备编号
        /// </summary>
        public string termId { get; set; } = string.Empty;

        /// <summary>
        /// String	否	医保结算参数 多个#分隔
        /// </summary>
        public string siInfo { get; set; } = string.Empty;

        ///// <summary>
        ///// 医保卡信息
        ///// </summary>
        //public string siCardInfo { get; set; }

        //public string siBalanceInfo { get; set; }

        //public string recipeSeq { get; set; }

        ///// <summary>
        ///// 最后组成的字符传(拆分)
        ///// </summary>
        //public string Recipe_CF { get; set; }

        ///// <summary>
        ///// 合同单位
        ///// </summary>
        //public string pactCode { get; set; }

        ///// <summary>
        ///// 身份证号
        ///// </summary>
        //public string idCard { get; set; }
    }

    public class Hosp4004ResponseData
    {
        /// <summary>
        /// 取药窗口
        /// </summary>
        public string windowNo { get; set; } = string.Empty;

        ///// <summary>
        ///// 发票号
        ///// </summary>
        //public string invoiceNo { get; set; }

        ///// <summary>
        ///// 发票序号
        ///// </summary>
        //public string invoiceSeq { get; set; }

        ///// <summary>
        ///// 社保卡交易流水号
        ///// </summary>

        //public string siTradeNo { get; set; }

        ///// <summary>
        ///// 余额
        ///// </summary>
        //public string vancy { get; set; }

        ///// <summary>
        ///// 执行科室
        ///// </summary>
        //public string deptname { get; set; }

        //public string FeeItemList { get; set; }
    }

    /// <summary>
    /// 4004 response
    /// </summary>
    public class Hosp4004Response : HospResponseModelBase<Hosp4004ResponseData> { }


    /// <summary>
    /// 4002 request
    /// </summary>
    public class Hosp4002Request : HospRequestModelBase
    {
        /// <summary>
        /// String	是	门诊挂号流水号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// String	否	就诊人卡号
        /// </summary>
        public string patientCard { get; set; } = string.Empty;

        //public string TradeCode { get; set; }
    }

    public class Hosp4002ResponseData
    {
        /// <summary>
        /// String	是	唯一号
        /// </summary>
        public string Recipe_Key { get; set; } = string.Empty;

        ///String	是	处方号
        public string Recipe_No { get; set; } = string.Empty;

        /// <summary>
        /// String	是	处方内序号
        /// </summary>
        public string SeqNo { get; set; } = string.Empty;

        /// <summary>
        /// String	是	交易类型
        /// </summary>
        public string Trans_Type { get; set; } = string.Empty;

        /// <summary>
        /// String	是	最小费用代码
        /// </summary>
        public string Fee_Code { get; set; } = string.Empty;

        /// <summary>
        /// 	String	是	是否是药品
        /// </summary>
        public string Drug_Flag { get; set; } = string.Empty;

        /// <summary>
        /// String	是	项目编码
        /// </summary>
        public string Item_Code { get; set; } = string.Empty;

        /// <summary>
        ///String	是	项目名称
        /// </summary>
        public string Item_Name { get; set; } = string.Empty;

        /// <summary>
        /// String	是	医保项目相关参数 多个#分隔
        /// </summary>
        public string Yb_Item_Info { get; set; } = string.Empty;

        /// <summary>
        /// String	是	数量
        /// </summary>
        public string Qty { get; set; } = string.Empty;

        ///// <summary>
        ///// 规格
        ///// </summary>
        //public string Spec { get; set; }

        //public string Dose { get; set; }

        ///// <summary>
        ///// 包装数量
        ///// </summary>
        //public string PackQty { get; set; }

        ///// <summary>
        ///// 天数
        ///// </summary>
        //public string Days { get; set; }

        ///// <summary>
        ///// 复方标识
        ///// </summary>
        //public string Ff { get; set; }

        //public string Center_Code { get; set; }

        /// <summary>
        /// String	是	单位
        /// </summary>
        public string UNIT { get; set; } = string.Empty;

        /// <summary>
        /// String	是	单价
        /// </summary>
        public string Unit_Price { get; set; } = string.Empty;

        /// <summary>
        /// String	是	总额
        /// </summary>
        public string Tot_Cost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	开方医生
        /// </summary>
        public string Doc_Name { get; set; } = string.Empty;

        ///// <summary>
        ///// 开单科室医生编号
        ///// </summary>
        //public string Doc_Code { get; set; }

        //public string OnceDose { get; set; }

        //public string Frequency { get; set; }

        /// <summary>
        /// String	是	开方医生所在科室
        /// </summary>
        public string DocDept_Name { get; set; } = string.Empty;

        /// <summary>
        /// String	是	执行科室
        /// </summary>
        public string Exec_DeptCode { get; set; } = string.Empty;

        /// <summary>
        /// String	是	执行科室名称
        /// </summary>
        public string Exec_DeptName { get; set; } = string.Empty;

        /// <summary>
        /// String	是	开立时间
        /// </summary>
        public string Mo_Date { get; set; } = string.Empty;

        /// <summary>
        /// 	String	是	是否收费
        /// </summary>
        public string Pay_Flag { get; set; } = string.Empty;

        ///// <summary>
        ///// String	是	发票号
        ///// </summary>
        //public string InvoiceNo { get; set; }

        ////public string Moder { get; set; }

        ///// <summary>
        ///// 挂号流水号
        ///// </summary>
        //public string ClinicCode { get; set; }

        //public string SysClass { get; set; }

        //public string Lab_Type { get; set; }

        //public string IsEmergency { get; set; }

        //public string hypo_test { get; set; }

        //public string combo { get; set; }

        //public string subcomb_no { get; set; }

        //public string usage_code { get; set; }

        //public string pact_name { get; set; }

        ///// <summary>
        ///// 物理卡号
        ///// </summary>
        //public string markno { get; set; }

        //public string price_unit { get; set; }

        //public string item_class { get; set; }

        //public string name { get; set; }

        //public string patientid { get; set; }

        //public string sex_code { get; set; }

        ///// <summary>
        ///// 分方
        ///// </summary>
        //public string recipeSeq { get; set; }

        ///// <summary>
        ///// 特慢病标识(0 普通 1特病  2 慢病)
        ///// </summary>
        //public string icdType { get; set; }

        ///// <summary>
        ///// 诊断编码
        ///// </summary>
        //public string icdCode { get; set; }

        ///// <summary>
        ///// 0  普通(不可报销)  1  可报销
        ///// </summary>
        //public string HasSaved { get; set; }

        ///// <summary>
        ///// 病种审批单号
        ///// </summary>
        //public string proCode { get; set; }

        ///// <summary>
        ///// 诊断名称
        ///// </summary>
        //public string icdName { get; set; }

        ///// <summary>
        ///// 值为PCC,是草药
        ///// </summary>
        //public string classCode { get; set; }

        //public string MinUnit { get; set; }
    }

    /// <summary>
    /// 4002 response
    /// </summary>
    public class Hosp4002Response : HospResponseModelBase<Hosp4002ResponseData[]> { }

    /// <summary>
    /// 4003 request
    /// </summary>
    public class Hosp4003Request : HospRequestModelBase
    {
        /// <summary>
        /// String 	是	唯一号 多个 | 分隔
        /// </summary>
        public string recipe_Key { get; set; } = string.Empty;

        /// <summary>
        /// String	是	就诊人姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// String	是	门诊流水号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// String	是	缴费操作员
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    public class Hosp4003ResponseData
    {
        /// <summary>
        /// String	是	总费用
        /// </summary>
        public string totCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	报销费用
        /// </summary>
        public string pubCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	个人卡内费用
        /// </summary>
        public string payCost { get; set; } = string.Empty;

        /// <summary>
        /// String	是	自费费用
        /// </summary>
        public string ownCost { get; set; } = string.Empty;
    }

    /// <summary>
    /// 4003 response
    /// </summary>
    public class Hosp4003Response : HospResponseModelBase<Hosp4003ResponseData> { }

    /// <summary>
    /// 预约取号入参
    /// </summary>
    public class Hosp2011Request : HospRequestModelBase
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string bookingNo { get; set; } = string.Empty;

        /// <summary>
        /// 挂号费用（单位:元）
        /// </summary>
        public string clinicFee { get; set; } = string.Empty;

        /// <summary>
        /// 自费医保病人标识
        /// </summary>
        public string pactCode { get; set; } = string.Empty;

        /// <summary>
        /// 支付方式 ZB 支付宝WX 微信CA 现金CD 银行卡
        /// </summary>
        public string feeSource { get; set; } = string.Empty;

        /// <summary>
        /// 支付流水号
        /// </summary>
        public string tradeNo { get; set; } = string.Empty;

        /// <summary>
        /// 云端默认用户就诊卡号
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    public class Hosp2011ResponseData
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// 预约取号返参
    /// </summary>
    public class Hosp2011Response : HospResponseModelBase<Hosp2011ResponseData> { }

    /// <summary>
    /// 挂号支付回调入参
    /// </summary>
    public class HospRegCallbackRequest : HospRequestModelBase
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// 支付流水号
        /// </summary>
        public string tradeNo { get; set; } = string.Empty;

        /// <summary>
        /// 第三方订单号
        /// </summary>
        public string thirdOrderNo { get; set; } = string.Empty;

        /// <summary>
        /// 支付方式 (支付必填)ZB 支付宝 WX 微信 CA 现金 CD 银行卡
        /// </summary>
        public string feeSource { get; set; } = string.Empty;

        /// <summary>
        /// 是否支付 0未支付 1账户支付 2已经支付
        /// </summary>
        public string isFee { get; set; } = string.Empty;

        /// <summary>
        /// 支付费用
        /// </summary>
        public string payFee { get; set; } = string.Empty;

        /// <summary>
        /// 医保结算参数多个#分隔
        /// </summary>
        public string siInfo { get; set; } = string.Empty;
    }

    public class HospRegCallbackResponseData
    {
        public int state { get; set; } = 0;
    }

    /// <summary>
    /// 挂号支付回调返参
    /// </summary>
    public class HospRegCallbackResponse : HospResponseModelBase<HospRegCallbackResponseData>
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// 1002 request
    /// </summary>
    public class Hosp1002Request : HospRequestModelBase
    {
        /// <summary>
        /// String	否	就诊人姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// String	否	就诊人身份证
        /// </summary>
        public string idCard { get; set; } = string.Empty;

        /// <summary>
        /// String	否	建档卡号
        /// </summary>
        public string mCardNo { get; set; } = string.Empty;

        /// <summary>
        /// String	否	建档卡号类型 5身份证 6医保卡  7银行卡
        /// </summary>
        public string mType { get; set; } = string.Empty;

        /// <summary>
        /// String	是	查询方式 0 自费患者查询  姓名和身份证  1 物理卡号查询
        /// </summary>
        public string queryType { get; set; } = string.Empty;

        //public string TradeCode { get; set; } = string.Empty;
    }

    public class Hosp1002ResponseData
    {
        /// <summary>
        /// 0000096874
        /// </summary>
        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        /// 毛萍
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// Vacancy
        /// </summary>
        public string vacancy { get; set; } = string.Empty;

        /// <summary>
        /// 女
        /// </summary>
        public string sex { get; set; } = string.Empty;

        /// <summary>
        /// 1988-07-09
        /// </summary>
        public string birthday { get; set; } = string.Empty;

        /// <summary>
        /// Linkman_name
        /// </summary>
        public string linkman_name { get; set; } = string.Empty;

        /// <summary>
        /// Linkman_add
        /// </summary>
        public string linkman_add { get; set; } = string.Empty;

        /// <summary>
        /// Linkman_tel
        /// </summary>
        public string linkman_tel { get; set; } = string.Empty;

        ///// <summary>
        ///// BingliCost
        ///// </summary>
        //public string bingliCost { get; set; } = string.Empty;

        /// <summary>
        /// PactCode
        /// </summary>
        public string pactCode { get; set; } = string.Empty;

        ///// <summary>
        ///// 18869906650
        ///// </summary>
        //public string idno { get; set; } = string.Empty;

        ///// <summary>
        ///// Idno2
        ///// </summary>
        //public string idno2 { get; set; } = string.Empty;
    }

    /// <summary>
    /// 1002 response
    /// </summary>
    public class Hosp1002Response : HospResponseModelBase<Hosp1002ResponseData> { }

    /// <summary>
    /// 3004 request
    /// </summary>
    public class Hosp3004Request : HospRequestModelBase
    {
        /// <summary>
        /// 是	排班编号（可为空）专家号必填
        /// </summary>
        public string shemaId { get; set; } = string.Empty;

        /// <summary>
        /// 就诊人真实姓名
        /// </summary>
        public string realName { get; set; } = string.Empty;

        ///// <summary>
        ///// 就诊人卡号
        ///// </summary>
        //public string mCardNo { get; set; }

        public string patientCard { get; set; } = string.Empty;

        /// <summary>
        /// 挂号科室名称
        /// </summary>
        public string departmentName { get; set; } = string.Empty;

        /// <summary>
        /// 挂号科室编号
        /// </summary>
        public string departmentCode { get; set; } = string.Empty;

        /// <summary>
        /// 医生名称
        /// </summary>
        public string doctorName { get; set; } = string.Empty;

        /// <summary>
        /// 医生编号
        /// </summary>
        public string doctorCode { get; set; } = string.Empty;

        /// <summary>
        /// 挂号级别
        /// </summary>
        public string registrationLevel { get; set; } = string.Empty;

        /// <summary>
        /// 挂号午别
        /// </summary>
        public string registrationNoonCode { get; set; } = string.Empty;

        /// <summary>
        /// 门诊类型  PT 普通门诊  ZJ 专家门诊
        /// </summary>
        public string registrationType { get; set; } = string.Empty;

        /// <summary>
        /// 挂号日期 yyyy-MM-dd
        /// </summary>
        public string registrationDate { get; set; } = string.Empty;

        /// <summary>
        /// 挂号时间段 08:00 如果挂号不到时间点 默认为空
        /// </summary>
        public string registrationTime { get; set; } = string.Empty;

        /// <summary>
        /// 挂号费用（单位:元）
        /// </summary>
        public string clinicFee { get; set; } = string.Empty;

        //public string totCost { get; set; }

        //public string pubCost { get; set; }

        //public string payCost { get; set; }

        //public string ownCost { get; set; }

        /// <summary>
        /// 自费医保病人标识
        /// </summary>
        public string pactCode { get; set; } = string.Empty;

        /// <summary>
        /// 自助机机器编号
        /// </summary>
        public string termId { get; set; } = string.Empty;

        /// <summary>
        /// 操作员工号
        /// </summary>
        public string operCode { get; set; } = string.Empty;

        /// <summary>
        /// 是否支付 0未支付 1账户支付 2已经支付
        /// </summary>
        public string isFee { get; set; } = string.Empty;

        ///// <summary>
        ///// 支付方式 （支付必填）ZB 支付宝WX 微信 CA 现金 CD 银行卡
        ///// </summary>
        //public string feeSource { get; set; }

        ///// <summary>
        ///// 支付流水号
        ///// </summary>
        //public string tradeNo { get; set; }

        ///// <summary>
        ///// 医保结算参数 多个#分隔
        ///// </summary>
        //public string siInfo { get; set; }

        ///// <summary>
        ///// 社保卡基本信息
        ///// </summary>
        //public string siCardInfo { get; set; }

        ///// <summary>
        ///// 社保卡余额
        ///// </summary>
        //public string siBalanceInfo { get; set; }

        //public string siReg { get; set; }

        //public string siRegInfo { get; set; }

        ///// <summary>
        ///// 32位的社会保障卡号
        ///// </summary>
        //public string siCode { get; set; }

        //public string idCard { get; set; }
    }

    public class Hosp3004ResponseData
    {
        /// <summary>
        /// 就诊唯一号
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        //public string hisRegisterId { get; set; }

        //public string registerId { get; set; }

        ///// <summary>
        ///// HIS交易发票号
        ///// </summary>
        //public string tradeNo { get; set; }

        //public string vancy { get; set; }

        /// <summary>
        /// 就诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;

        //public string address { get; set; }

        //public string deptname { get; set; }
    }

    /// <summary>
    /// 3004 response
    /// </summary>
    public class Hosp3004Response : HospResponseModelBase<Hosp3004ResponseData> { }

    /// <summary>
    /// 2007 request
    /// </summary>
    [HospTransferCode("2007")]
    public class Hosp2007Request : HospRequestModelBase
    {
        /// <summary>
        /// String	是	预约唯一号
        /// </summary>
        public string bookingNo { get; set; } = string.Empty;

        /// <summary>
        /// String	是	操作员
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    public class Hosp2007ResponseData
    {
        public int state { get; set; } = 0;
    }

    /// <summary>
    /// 2007 response
    /// </summary>
    public class Hosp2007Response : HospResponseModelBase<Hosp2007ResponseData> { }

    /// <summary>
    /// 2008 request
    /// </summary>
    [HospTransferCode("2008")]
    public class Hosp2008Request : HospRequestModelBase
    {
        /// <summary>
        /// String	否	排班编号 专家挂号必填
        /// </summary>
        public string shemaId { get; set; } = string.Empty;

        /// <summary>
        /// 患者卡号
        /// </summary>
        public string cardNo { get; set; } = string.Empty;

        /// <summary>
        ///患者姓名 
        /// </summary>
        public string realName { get; set; } = string.Empty;

        /// <summary>
        /// 是否专家挂号 1 专家  0 不是专家
        /// </summary>
        public string isExpert { get; set; } = string.Empty;

        /// <summary>
        /// String	否	科室代码  不是专家必填
        /// </summary>
        public string deptCode { get; set; } = string.Empty;

        /// <summary>
        /// 预约时间 yyyy-MM-ddHH:mi:ss
        /// </summary>
        public string preTime { get; set; } = string.Empty;

        /// <summary>
        /// 是否支付 0 未支付 1 账户支付 2 已经支付
        /// </summary>
        public string isFee { get; set; } = string.Empty;

        /// <summary>
        /// 总费用
        /// </summary>
        public string clinicFee { get; set; } = string.Empty;

        /// <summary>
        /// 预约来源 标识厂商
        /// </summary>
        public string bookSource { get; set; } = string.Empty;

        ///// <summary>
        ///// 1 预约挂号取号  2 预约挂号直接就诊
        ///// </summary>
        //public string bookType { get; set; }

        ///// <summary>
        ///// 支付方式 CA 现金 ZB 支付宝 WX 微信
        ///// </summary>
        //public string feeSource { get; set; }

        ///// <summary>
        ///// 第三方订单流水号
        ///// </summary>
        //public string tradeNo { get; set; }

        ///// <summary>
        ///// 取号验证码
        ///// </summary>
        //public string IdentifyCode { get; set; }

        ///// <summary>
        ///// 操作员
        ///// </summary>
        //public string operCode { get; set; }

        ///// <summary>
        ///// 自助机终端号
        ///// </summary>
        //public string termId { get; set; }
    }

    public class Hosp2008ResponseData
    {
        /// <summary>
        /// 预约唯一号
        /// </summary>
        public string bookingNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊唯一号 
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// 就诊序号
        /// </summary>
        public string seeNo { get; set; } = string.Empty;
    }

    /// <summary>
    /// 2008 response
    /// </summary>
    public class Hosp2008Response : HospResponseModelBase<Hosp2008ResponseData> { }

    /// <summary>
    /// 3005 request
    /// </summary>
    [HospTransferCode("3005")]
    public class Hosp3005Request : HospRequestModelBase
    {
        /// <summary>
        /// String	是	挂号唯一号（his）
        /// </summary>
        public string clinicNo { get; set; } = string.Empty;

        /// <summary>
        /// string	是	操作员工号
        /// </summary>
        public string operCode { get; set; } = string.Empty;
    }

    public class Hosp3005ResponseData
    {
        public int state { get; set; } = 0;
    }

    /// <summary>
    /// 3005 response
    /// </summary>
    public class Hosp3005Response : HospResponseModelBase<Hosp3005ResponseData> { }

    /// <summary>
    /// 2003 request
    /// </summary>
    [HospTransferCode("2003")]
    public class Hosp2003Request : HospRequestModelBase
    {
        /// <summary>
        /// 开始时间 yyyy-MM-dd
        /// </summary>
        public string beginDate { get; set; } = string.Empty;

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

    public class Hosp2003ResponseData
    {
        /// <summary>
        /// string	是	排班ID
        /// </summary>
        public string ID { get; set; } = string.Empty;

        /// <summary>
        /// string	否	看诊时间 
        /// </summary>
        public string SEE_DATE { get; set; } = string.Empty;

        /// <summary>
        /// string	是	星期几
        /// </summary>
        public string WEEK { get; set; } = string.Empty;

        /// <summary>
        /// string	是	午别
        /// </summary>
        public string NOONCODE { get; set; } = string.Empty;

        /// <summary>
        /// 午别名称
        /// </summary>
        public string NOONNAME { get; set; } = string.Empty;

        /// <summary>
        /// string	是	开始时间
        /// </summary>
        public string BEGIN_TIME { get; set; } = string.Empty;

        /// <summary>
        /// string	是	结束时间
        /// </summary>
        public string END_TIME { get; set; } = string.Empty;

        /// <summary>
        /// string	是	科室编码
        /// </summary>
        public string DEPT_CODE { get; set; } = string.Empty;

        /// <summary>
        /// string	否	科室名称
        /// </summary>
        public string DEPT_NAME { get; set; } = string.Empty;

        /// <summary>
        /// string	否	医生编码
        /// </summary>
        public string DOCT_CODE { get; set; } = string.Empty;

        /// <summary>
        /// //string	是	医生名称
        /// </summary>
        public string DOCT_NAME { get; set; } = string.Empty;

        /// <summary>
        /// string	是	预约总数
        /// </summary>
        //public string REG_LMT { get; set; }

        public string BOOKING_LMT { get; set; } = string.Empty;

        /// <summary>
        /// string	是	已经预约数
        /// </summary>
        // public string REG_REGED { get; set; }
        public string TEL_REGED { get; set; } = string.Empty;

        /// <summary>
        /// 挂号等级代码
        /// </summary>
        public string REGLEVL_CODE { get; set; } = string.Empty;

        /// <summary>
        /// string	是	挂号等级
        /// </summary>
        public string REGLEVL_NAME { get; set; } = string.Empty;

        /// <summary>
        /// string	是	挂号金额
        /// </summary>
        public string TOT_COST { get; set; } = string.Empty;

        /// <summary>
        /// string	是	科室地址
        /// </summary>
        public string ADRESS { get; set; } = string.Empty;

        /// <summary>
        /// string	是	0(PT) 普通号 1(ZJ) 专家号
        /// </summary>
        public string REGISTRATION_TYPE { get; set; } = string.Empty;

        /// <summary>
        /// HIS项目编码(根据此字段1005查询医保中心对应的项目编码和医院的自付比率)
        /// </summary>
        public string ITEMCODE { get; set; } = string.Empty;

        /// <summary>
        /// 排序ID
        /// </summary>
        public string SORTID { get; set; } = string.Empty;

        /// <summary>
        /// 剩余挂号数
        /// </summary>
        public string HASREG { get; set; } = string.Empty;
    }

    /// <summary>
    /// 2003 response
    /// </summary>
    public class Hosp2003Response : HospResponseModelBase<Hosp2003ResponseData[]> { }
}
