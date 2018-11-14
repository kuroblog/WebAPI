using Newtonsoft.Json;
using System;
using System.Linq;

namespace Flysh.Hosp.ProxyApi.Models.HOSP.JHWR
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
    /// 2008 request
    /// </summary>
    [HospTransferCode("2008")]
    public class Hosp2008Request : HospRequestModelBase
    {
        /// <summary>
        /// String	否	排班编号 专家挂号必填
        /// </summary>
        public string shemaId { get; set; }

        /// <summary>
        /// 患者卡号
        /// </summary>
        public string cardNo { get; set; }

        /// <summary>
        ///患者姓名 
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 是否专家挂号 1 专家  0 不是专家
        /// </summary>
        public string isExpert { get; set; }

        /// <summary>
        /// String	否	科室代码  不是专家必填
        /// </summary>
        public string deptCode { get; set; }

        /// <summary>
        /// 预约时间 yyyy-MM-ddHH:mi:ss
        /// </summary>
        public string preTime { get; set; }

        /// <summary>
        /// 是否支付 0 未支付 1 账户支付 2 已经支付
        /// </summary>
        public string isFee { get; set; }

        /// <summary>
        /// 总费用
        /// </summary>
        public string clinicFee { get; set; }

        /// <summary>
        /// 预约来源 标识厂商
        /// </summary>
        public string bookSource { get; set; }

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
        public string clinicNo { get; set; }

        /// <summary>
        /// string	是	操作员工号
        /// </summary>
        public string operCode { get; set; }
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
