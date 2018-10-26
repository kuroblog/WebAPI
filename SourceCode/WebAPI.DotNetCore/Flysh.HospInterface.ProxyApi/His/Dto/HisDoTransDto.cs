
namespace Flysh.HospInterface.ProxyApi.His.Dto
{
    using Gboxt.Common.DataModel;
    using JHWR;
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class HisDoTransRequest<TData> : IApiArgument
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual TData data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HisDoTransRequest(string code, TData data)
        {
            this.code = code;
            this.data = data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Validate(out string message)
        {
            message = string.Empty;

            return string.IsNullOrEmpty(message);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class HisDoTransRequestExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THisDoTransRequest"></typeparam>
        /// <typeparam name="TData"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DoTransRequest GetRequestData<THisDoTransRequest, TData>(this THisDoTransRequest request)
            where THisDoTransRequest : HisDoTransRequest<TData>
        {
            var jsonString = request.data == null ? string.Empty : request.data.GetType() == typeof(string) ? $"{request.data}" : JsonConvert.SerializeObject(request.data);

            return new DoTransRequest(new DoTransRequestBody(request.code, jsonString));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BaseHisResponse
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
    public class BaseHisDataResponse<TData> : BaseHisResponse
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
    public class HisDoTransResponse<TData> : BaseHisDataResponse<TData>
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
    /// 
    /// </summary>
    public class HisShemaInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SEE_DATE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WEEK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NOONCODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BEGIN_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string END_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DEPT_CODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DEPT_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DOCT_CODE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DOCT_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string REG_LMT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string REG_REGED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string REGLEVL_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TOT_COST { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ADRESS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string REGISTRATION_TYPE { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisShemaPointResponse : BaseHisResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string timeinfo { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisSaveBookingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string bookingNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string clinicNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string seeNo { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisBookingInfoResponse : BaseHisResponse
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
    /// 
    /// </summary>
    public class HisRegisterInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string clinicNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string seeNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string tradeNo { get; set; }

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
    /// 
    /// </summary>
    public class HisFeeRegInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string Recipe_Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Recipe_No { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SeqNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Trans_Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Fee_Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Drug_Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Item_Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Item_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Yb_Item_Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Qty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Unit_Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UNIT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tot_Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Doc_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DocDept_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Exec_DeptCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Exec_DeptName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Mo_Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Pay_Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisReportInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string queryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string realName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string checkType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
    }
}
