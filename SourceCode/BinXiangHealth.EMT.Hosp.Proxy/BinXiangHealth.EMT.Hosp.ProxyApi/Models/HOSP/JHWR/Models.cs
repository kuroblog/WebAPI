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
