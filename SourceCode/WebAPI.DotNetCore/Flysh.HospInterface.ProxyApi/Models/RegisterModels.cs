
namespace Flysh.HospInterface.ProxyApi.Models
{
    using Flysh.HospInterface.ProxyApi.Infrastructures;

    /// <summary>
    /// 挂号 request [3004]
    /// </summary>
    public class RegisterSubmitRequest : ApiRequestBase
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
        /// unknown
        /// </summary>
        public string totCost { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string patientCard { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string pubCost { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string payCost { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string ownCost { get; set; }

        /// <summary>
        /// 社保卡基本信息
        /// </summary>
        public string siCardInfo { get; set; }

        /// <summary>
        /// 社保卡余额
        /// </summary>
        public string siBalanceInfo { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string siReg { get; set; }

        /// <summary>
        /// unknown
        /// </summary>
        public string siRegInfo { get; set; }

        /// <summary>
        /// 32位的社会保障卡号
        /// </summary>
        public string siCode { get; set; }

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
    /// 取消挂号 request [3005]
    /// </summary>
    public class RegisterCancelRequest : ApiRequestBase
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

    /// <summary>
    /// 挂号查询 request [4000]
    /// </summary>
    public class RegisterQueryRequest : ApiRequestBase
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 就诊人卡号
        /// </summary>
        public string patientCard { get; set; }

        /// <summary>
        /// 查询方式  0 所以有效记录 1 存在未收费的记录
        /// </summary>
        public string queryType { get; set; }

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
            else if (string.IsNullOrEmpty(patientCard))
            {
                message = ErrorMessage(() => patientCard);
            }
            else if (string.IsNullOrEmpty(queryType))
            {
                message = ErrorMessage(() => queryType);
            }

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 挂号查询结果
    /// </summary>
    public class RegisterQueryData
    {
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 挂号时间
        /// </summary>
        public string regDate { get; set; }

        /// <summary>
        /// 挂号科室
        /// </summary>
        public string deptName { get; set; }

        /// <summary>
        /// 挂号医生
        /// </summary>
        public string doctName { get; set; }

        /// <summary>
        /// 未看诊 已看诊
        /// </summary>
        public string ynSee { get; set; }

        /// <summary>
        /// 挂号流水号
        /// </summary>
        public string clinicCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RegisterQueryItem[] datas { get; set; }

        /// <summary>
        /// 医保比例
        /// </summary>
        public string ybRate { get; set; }

        /// <summary>
        /// 医保中心代码
        /// </summary>
        public string ybCode { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class RegisterQueryItem
    {
        /// <summary>
        /// 唯一号
        /// </summary>
        public string recipeId { get; set; }

        ///处方号
        public string recipeNo { get; set; }

        /// <summary>
        /// 处方内序号
        /// </summary>
        public string seqNo { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string transType { get; set; }

        /// <summary>
        /// 最小费用代码
        /// </summary>
        public string feeCode { get; set; }

        /// <summary>
        /// 是否是药品
        /// </summary>
        public string drugFlag { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string itemCode { get; set; }

        /// <summary>
        ///项目名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 医保项目相关参数 多个#分隔
        /// </summary>
        public string ybItemInfo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string qty { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string spec { get; set; }

        /// <summary>
        /// 包装数量
        /// </summary>
        public string packQty { get; set; }

        /// <summary>
        /// 天数
        /// </summary>
        public string days { get; set; }

        /// <summary>
        /// 复方标识
        /// </summary>
        public string ff { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public string unitPrice { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// 总额
        /// </summary>
        public string totCost { get; set; }

        /// <summary>
        /// 开方医生
        /// </summary>
        public string doctName { get; set; }

        /// <summary>
        /// 开单科室医生编号
        /// </summary>
        public string doctCode { get; set; }
        /// <summary>
        /// 开方医生所在科室
        /// </summary>
        public string doctDeptName { get; set; }

        /// <summary>
        /// 执行科室
        /// </summary>
        public string execDeptCode { get; set; }

        /// <summary>
        /// 执行科室名称
        /// </summary>
        public string execDeptName { get; set; }

        /// <summary>
        /// 开立时间
        /// </summary>
        public string moDate { get; set; }

        /// <summary>
        /// 	是否收费
        /// </summary>
        public string payFlag { get; set; }

        /// <summary>
        /// 发票号
        /// </summary>
        public string invoiceNo { get; set; }

        /// <summary>
        /// 挂号流水号
        /// </summary>
        public string clinicCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string dose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string onceDose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string frequency { get; set; }

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
        public string hasSaved { get; set; }

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
