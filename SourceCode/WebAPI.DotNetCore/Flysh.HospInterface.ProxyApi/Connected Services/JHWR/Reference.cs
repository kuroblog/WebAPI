//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace JHWR
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JHWR.CallServiceSoapClientJHWRSoap")]
    public interface CallServiceSoapClientJHWRSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.HelloWorldResponse> HelloWorldAsync(JHWR.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoTrans", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.DoTransResponse> DoTransAsync(JHWR.DoTransRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OPAutoPayment", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.OPAutoPaymentResponse> OPAutoPaymentAsync(JHWR.OPAutoPaymentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getScanPayQR", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.getScanPayQRResponse> getScanPayQRAsync(JHWR.getScanPayQRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ScanPayQuery", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.ScanPayQueryResponse> ScanPayQueryAsync(JHWR.ScanPayQueryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/runservice", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.runserviceResponse> runserviceAsync(JHWR.runserviceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelfRegService", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.SelfRegServiceResponse> SelfRegServiceAsync(JHWR.SelfRegServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetINVImage", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetINVImageResponse> GetINVImageAsync(JHWR.GetINVImageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPatInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetPatInfoResponse> GetPatInfoAsync(JHWR.GetPatInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddOPDeposit", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.AddOPDepositResponse> AddOPDepositAsync(JHWR.AddOPDepositRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOPAccPreDeposit", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetOPAccPreDepositResponse> GetOPAccPreDepositAsync(JHWR.GetOPAccPreDepositRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAccPayList", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetAccPayListResponse> GetAccPayListAsync(JHWR.GetAccPayListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAdmByCardNo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetAdmByCardNoResponse> GetAdmByCardNoAsync(JHWR.GetAdmByCardNoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBillInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetBillInfoResponse> GetBillInfoAsync(JHWR.GetBillInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoOPBillCharge", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.AutoOPBillChargeResponse> AutoOPBillChargeAsync(JHWR.AutoOPBillChargeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InserBankTradeInfoSingle", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.InserBankTradeInfoSingleResponse> InserBankTradeInfoSingleAsync(JHWR.InserBankTradeInfoSingleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOPInvTarDetail", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetOPInvTarDetailResponse> GetOPInvTarDetailAsync(JHWR.GetOPInvTarDetailRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCompletedPayInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetCompletedPayInfoResponse> GetCompletedPayInfoAsync(JHWR.GetCompletedPayInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCompletedPayDetailInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetCompletedPayDetailInfoResponse> GetCompletedPayDetailInfoAsync(JHWR.GetCompletedPayDetailInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMedPrice", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetMedPriceResponse> GetMedPriceAsync(JHWR.GetMedPriceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTarItemPrice", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetTarItemPriceResponse> GetTarItemPriceAsync(JHWR.GetTarItemPriceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindPatientCard", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.FindPatientCardResponse> FindPatientCardAsync(JHWR.FindPatientCardRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SavePatientCard", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.SavePatientCardResponse> SavePatientCardAsync(JHWR.SavePatientCardRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BookService", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.BookServiceResponse> BookServiceAsync(JHWR.BookServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.QueryOrderResponse> QueryOrderAsync(JHWR.QueryOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CancelOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.CancelOrderResponse> CancelOrderAsync(JHWR.CancelOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OPAppArrive", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.OPAppArriveResponse> OPAppArriveAsync(JHWR.OPAppArriveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIPPatAdmInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetIPPatAdmInfoResponse> GetIPPatAdmInfoAsync(JHWR.GetIPPatAdmInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIPPatientInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetIPPatientInfoResponse> GetIPPatientInfoAsync(JHWR.GetIPPatientInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddIPDeposit", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.AddIPDepositResponse> AddIPDepositAsync(JHWR.AddIPDepositRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDepPayRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetDepPayRecordResponse> GetDepPayRecordAsync(JHWR.GetDepPayRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIPDepositRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetIPDepositRecordResponse> GetIPDepositRecordAsync(JHWR.GetIPDepositRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIPDailyBill", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetIPDailyBillResponse> GetIPDailyBillAsync(JHWR.GetIPDailyBillRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIPTotalCost", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetIPTotalCostResponse> GetIPTotalCostAsync(JHWR.GetIPTotalCostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIPDetailCost", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetIPDetailCostResponse> GetIPDetailCostAsync(JHWR.GetIPDetailCostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIPAdmInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetIPAdmInfoResponse> GetIPAdmInfoAsync(JHWR.GetIPAdmInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckBillFee", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.CheckBillFeeResponse> CheckBillFeeAsync(JHWR.CheckBillFeeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPBillPay", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.IPBillPayResponse> IPBillPayAsync(JHWR.IPBillPayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PayResult", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.PayResultResponse> PayResultAsync(JHWR.PayResultRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTodayPrintList", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetTodayPrintListResponse> GetTodayPrintListAsync(JHWR.GetTodayPrintListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoZZJDailyReport", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.AutoZZJDailyReportResponse> AutoZZJDailyReportAsync(JHWR.AutoZZJDailyReportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Print", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.PrintResponse> PrintAsync(JHWR.PrintRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRPTInfoByPatientNo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetRPTInfoByPatientNoResponse> GetRPTInfoByPatientNoAsync(JHWR.GetRPTInfoByPatientNoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdatePrintSignByRptId", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.UpdatePrintSignByRptIdResponse> UpdatePrintSignByRptIdAsync(JHWR.UpdatePrintSignByRptIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryDepartment", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.QueryDepartmentResponse> QueryDepartmentAsync(JHWR.QueryDepartmentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryAdmSchedule", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.QueryAdmScheduleResponse> QueryAdmScheduleAsync(JHWR.QueryAdmScheduleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInsuRegPara", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.GetInsuRegParaResponse> GetInsuRegParaAsync(JHWR.GetInsuRegParaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LockOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.LockOrderResponse> LockOrderAsync(JHWR.LockOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OPRegister", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.OPRegisterResponse> OPRegisterAsync(JHWR.OPRegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryAdmOPReg", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.QueryAdmOPRegResponse> QueryAdmOPRegAsync(JHWR.QueryAdmOPRegRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindCheckOrderByType", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.FindCheckOrderByTypeResponse> FindCheckOrderByTypeAsync(JHWR.FindCheckOrderByTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveCheckOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.SaveCheckOrderResponse> SaveCheckOrderAsync(JHWR.SaveCheckOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryScheduleTimeInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<JHWR.QueryScheduleTimeInfoResponse> QueryScheduleTimeInfoAsync(JHWR.QueryScheduleTimeInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.HelloWorldRequestBody Body;
        
        public HelloWorldRequest()
        {
        }
        
        public HelloWorldRequest(JHWR.HelloWorldRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody
    {
        
        public HelloWorldRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.HelloWorldResponseBody Body;
        
        public HelloWorldResponse()
        {
        }
        
        public HelloWorldResponse(JHWR.HelloWorldResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody()
        {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoTransRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoTrans", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.DoTransRequestBody Body;
        
        public DoTransRequest()
        {
        }
        
        public DoTransRequest(JHWR.DoTransRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DoTransRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string transCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string inJsonString;
        
        public DoTransRequestBody()
        {
        }
        
        public DoTransRequestBody(string transCode, string inJsonString)
        {
            this.transCode = transCode;
            this.inJsonString = inJsonString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoTransResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoTransResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.DoTransResponseBody Body;
        
        public DoTransResponse()
        {
        }
        
        public DoTransResponse(JHWR.DoTransResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DoTransResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DoTransResult;
        
        public DoTransResponseBody()
        {
        }
        
        public DoTransResponseBody(string DoTransResult)
        {
            this.DoTransResult = DoTransResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OPAutoPaymentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OPAutoPayment", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.OPAutoPaymentRequestBody Body;
        
        public OPAutoPaymentRequest()
        {
        }
        
        public OPAutoPaymentRequest(JHWR.OPAutoPaymentRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OPAutoPaymentRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public OPAutoPaymentRequestBody()
        {
        }
        
        public OPAutoPaymentRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OPAutoPaymentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OPAutoPaymentResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.OPAutoPaymentResponseBody Body;
        
        public OPAutoPaymentResponse()
        {
        }
        
        public OPAutoPaymentResponse(JHWR.OPAutoPaymentResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OPAutoPaymentResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string OPAutoPaymentResult;
        
        public OPAutoPaymentResponseBody()
        {
        }
        
        public OPAutoPaymentResponseBody(string OPAutoPaymentResult)
        {
            this.OPAutoPaymentResult = OPAutoPaymentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getScanPayQRRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getScanPayQR", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.getScanPayQRRequestBody Body;
        
        public getScanPayQRRequest()
        {
        }
        
        public getScanPayQRRequest(JHWR.getScanPayQRRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getScanPayQRRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public getScanPayQRRequestBody()
        {
        }
        
        public getScanPayQRRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getScanPayQRResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getScanPayQRResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.getScanPayQRResponseBody Body;
        
        public getScanPayQRResponse()
        {
        }
        
        public getScanPayQRResponse(JHWR.getScanPayQRResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getScanPayQRResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getScanPayQRResult;
        
        public getScanPayQRResponseBody()
        {
        }
        
        public getScanPayQRResponseBody(string getScanPayQRResult)
        {
            this.getScanPayQRResult = getScanPayQRResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ScanPayQueryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ScanPayQuery", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.ScanPayQueryRequestBody Body;
        
        public ScanPayQueryRequest()
        {
        }
        
        public ScanPayQueryRequest(JHWR.ScanPayQueryRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ScanPayQueryRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public ScanPayQueryRequestBody()
        {
        }
        
        public ScanPayQueryRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ScanPayQueryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ScanPayQueryResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.ScanPayQueryResponseBody Body;
        
        public ScanPayQueryResponse()
        {
        }
        
        public ScanPayQueryResponse(JHWR.ScanPayQueryResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ScanPayQueryResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ScanPayQueryResult;
        
        public ScanPayQueryResponseBody()
        {
        }
        
        public ScanPayQueryResponseBody(string ScanPayQueryResult)
        {
            this.ScanPayQueryResult = ScanPayQueryResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class runserviceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="runservice", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.runserviceRequestBody Body;
        
        public runserviceRequest()
        {
        }
        
        public runserviceRequest(JHWR.runserviceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class runserviceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public runserviceRequestBody()
        {
        }
        
        public runserviceRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class runserviceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="runserviceResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.runserviceResponseBody Body;
        
        public runserviceResponse()
        {
        }
        
        public runserviceResponse(JHWR.runserviceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class runserviceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string runserviceResult;
        
        public runserviceResponseBody()
        {
        }
        
        public runserviceResponseBody(string runserviceResult)
        {
            this.runserviceResult = runserviceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelfRegServiceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelfRegService", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.SelfRegServiceRequestBody Body;
        
        public SelfRegServiceRequest()
        {
        }
        
        public SelfRegServiceRequest(JHWR.SelfRegServiceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelfRegServiceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string requestCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string InValue;
        
        public SelfRegServiceRequestBody()
        {
        }
        
        public SelfRegServiceRequestBody(string requestCode, string InValue)
        {
            this.requestCode = requestCode;
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelfRegServiceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelfRegServiceResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.SelfRegServiceResponseBody Body;
        
        public SelfRegServiceResponse()
        {
        }
        
        public SelfRegServiceResponse(JHWR.SelfRegServiceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelfRegServiceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SelfRegServiceResult;
        
        public SelfRegServiceResponseBody()
        {
        }
        
        public SelfRegServiceResponseBody(string SelfRegServiceResult)
        {
            this.SelfRegServiceResult = SelfRegServiceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetINVImageRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetINVImage", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetINVImageRequestBody Body;
        
        public GetINVImageRequest()
        {
        }
        
        public GetINVImageRequest(JHWR.GetINVImageRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetINVImageRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetINVImageRequestBody()
        {
        }
        
        public GetINVImageRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetINVImageResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetINVImageResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetINVImageResponseBody Body;
        
        public GetINVImageResponse()
        {
        }
        
        public GetINVImageResponse(JHWR.GetINVImageResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetINVImageResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetINVImageResult;
        
        public GetINVImageResponseBody()
        {
        }
        
        public GetINVImageResponseBody(string GetINVImageResult)
        {
            this.GetINVImageResult = GetINVImageResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPatInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPatInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetPatInfoRequestBody Body;
        
        public GetPatInfoRequest()
        {
        }
        
        public GetPatInfoRequest(JHWR.GetPatInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPatInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetPatInfoRequestBody()
        {
        }
        
        public GetPatInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPatInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPatInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetPatInfoResponseBody Body;
        
        public GetPatInfoResponse()
        {
        }
        
        public GetPatInfoResponse(JHWR.GetPatInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPatInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetPatInfoResult;
        
        public GetPatInfoResponseBody()
        {
        }
        
        public GetPatInfoResponseBody(string GetPatInfoResult)
        {
            this.GetPatInfoResult = GetPatInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddOPDepositRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddOPDeposit", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AddOPDepositRequestBody Body;
        
        public AddOPDepositRequest()
        {
        }
        
        public AddOPDepositRequest(JHWR.AddOPDepositRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddOPDepositRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public AddOPDepositRequestBody()
        {
        }
        
        public AddOPDepositRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddOPDepositResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddOPDepositResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AddOPDepositResponseBody Body;
        
        public AddOPDepositResponse()
        {
        }
        
        public AddOPDepositResponse(JHWR.AddOPDepositResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddOPDepositResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddOPDepositResult;
        
        public AddOPDepositResponseBody()
        {
        }
        
        public AddOPDepositResponseBody(string AddOPDepositResult)
        {
            this.AddOPDepositResult = AddOPDepositResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOPAccPreDepositRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOPAccPreDeposit", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetOPAccPreDepositRequestBody Body;
        
        public GetOPAccPreDepositRequest()
        {
        }
        
        public GetOPAccPreDepositRequest(JHWR.GetOPAccPreDepositRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetOPAccPreDepositRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetOPAccPreDepositRequestBody()
        {
        }
        
        public GetOPAccPreDepositRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOPAccPreDepositResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOPAccPreDepositResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetOPAccPreDepositResponseBody Body;
        
        public GetOPAccPreDepositResponse()
        {
        }
        
        public GetOPAccPreDepositResponse(JHWR.GetOPAccPreDepositResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetOPAccPreDepositResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetOPAccPreDepositResult;
        
        public GetOPAccPreDepositResponseBody()
        {
        }
        
        public GetOPAccPreDepositResponseBody(string GetOPAccPreDepositResult)
        {
            this.GetOPAccPreDepositResult = GetOPAccPreDepositResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAccPayListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccPayList", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetAccPayListRequestBody Body;
        
        public GetAccPayListRequest()
        {
        }
        
        public GetAccPayListRequest(JHWR.GetAccPayListRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAccPayListRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetAccPayListRequestBody()
        {
        }
        
        public GetAccPayListRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAccPayListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccPayListResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetAccPayListResponseBody Body;
        
        public GetAccPayListResponse()
        {
        }
        
        public GetAccPayListResponse(JHWR.GetAccPayListResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAccPayListResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAccPayListResult;
        
        public GetAccPayListResponseBody()
        {
        }
        
        public GetAccPayListResponseBody(string GetAccPayListResult)
        {
            this.GetAccPayListResult = GetAccPayListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAdmByCardNoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAdmByCardNo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetAdmByCardNoRequestBody Body;
        
        public GetAdmByCardNoRequest()
        {
        }
        
        public GetAdmByCardNoRequest(JHWR.GetAdmByCardNoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAdmByCardNoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetAdmByCardNoRequestBody()
        {
        }
        
        public GetAdmByCardNoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAdmByCardNoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAdmByCardNoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetAdmByCardNoResponseBody Body;
        
        public GetAdmByCardNoResponse()
        {
        }
        
        public GetAdmByCardNoResponse(JHWR.GetAdmByCardNoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAdmByCardNoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAdmByCardNoResult;
        
        public GetAdmByCardNoResponseBody()
        {
        }
        
        public GetAdmByCardNoResponseBody(string GetAdmByCardNoResult)
        {
            this.GetAdmByCardNoResult = GetAdmByCardNoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBillInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBillInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetBillInfoRequestBody Body;
        
        public GetBillInfoRequest()
        {
        }
        
        public GetBillInfoRequest(JHWR.GetBillInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBillInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetBillInfoRequestBody()
        {
        }
        
        public GetBillInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBillInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBillInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetBillInfoResponseBody Body;
        
        public GetBillInfoResponse()
        {
        }
        
        public GetBillInfoResponse(JHWR.GetBillInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBillInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetBillInfoResult;
        
        public GetBillInfoResponseBody()
        {
        }
        
        public GetBillInfoResponseBody(string GetBillInfoResult)
        {
            this.GetBillInfoResult = GetBillInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoOPBillChargeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoOPBillCharge", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AutoOPBillChargeRequestBody Body;
        
        public AutoOPBillChargeRequest()
        {
        }
        
        public AutoOPBillChargeRequest(JHWR.AutoOPBillChargeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AutoOPBillChargeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public AutoOPBillChargeRequestBody()
        {
        }
        
        public AutoOPBillChargeRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoOPBillChargeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoOPBillChargeResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AutoOPBillChargeResponseBody Body;
        
        public AutoOPBillChargeResponse()
        {
        }
        
        public AutoOPBillChargeResponse(JHWR.AutoOPBillChargeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AutoOPBillChargeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AutoOPBillChargeResult;
        
        public AutoOPBillChargeResponseBody()
        {
        }
        
        public AutoOPBillChargeResponseBody(string AutoOPBillChargeResult)
        {
            this.AutoOPBillChargeResult = AutoOPBillChargeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InserBankTradeInfoSingleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InserBankTradeInfoSingle", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.InserBankTradeInfoSingleRequestBody Body;
        
        public InserBankTradeInfoSingleRequest()
        {
        }
        
        public InserBankTradeInfoSingleRequest(JHWR.InserBankTradeInfoSingleRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InserBankTradeInfoSingleRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public InserBankTradeInfoSingleRequestBody()
        {
        }
        
        public InserBankTradeInfoSingleRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InserBankTradeInfoSingleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InserBankTradeInfoSingleResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.InserBankTradeInfoSingleResponseBody Body;
        
        public InserBankTradeInfoSingleResponse()
        {
        }
        
        public InserBankTradeInfoSingleResponse(JHWR.InserBankTradeInfoSingleResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InserBankTradeInfoSingleResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InserBankTradeInfoSingleResult;
        
        public InserBankTradeInfoSingleResponseBody()
        {
        }
        
        public InserBankTradeInfoSingleResponseBody(string InserBankTradeInfoSingleResult)
        {
            this.InserBankTradeInfoSingleResult = InserBankTradeInfoSingleResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOPInvTarDetailRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOPInvTarDetail", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetOPInvTarDetailRequestBody Body;
        
        public GetOPInvTarDetailRequest()
        {
        }
        
        public GetOPInvTarDetailRequest(JHWR.GetOPInvTarDetailRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetOPInvTarDetailRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetOPInvTarDetailRequestBody()
        {
        }
        
        public GetOPInvTarDetailRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOPInvTarDetailResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOPInvTarDetailResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetOPInvTarDetailResponseBody Body;
        
        public GetOPInvTarDetailResponse()
        {
        }
        
        public GetOPInvTarDetailResponse(JHWR.GetOPInvTarDetailResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetOPInvTarDetailResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetOPInvTarDetailResult;
        
        public GetOPInvTarDetailResponseBody()
        {
        }
        
        public GetOPInvTarDetailResponseBody(string GetOPInvTarDetailResult)
        {
            this.GetOPInvTarDetailResult = GetOPInvTarDetailResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCompletedPayInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCompletedPayInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetCompletedPayInfoRequestBody Body;
        
        public GetCompletedPayInfoRequest()
        {
        }
        
        public GetCompletedPayInfoRequest(JHWR.GetCompletedPayInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCompletedPayInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetCompletedPayInfoRequestBody()
        {
        }
        
        public GetCompletedPayInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCompletedPayInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCompletedPayInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetCompletedPayInfoResponseBody Body;
        
        public GetCompletedPayInfoResponse()
        {
        }
        
        public GetCompletedPayInfoResponse(JHWR.GetCompletedPayInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCompletedPayInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCompletedPayInfoResult;
        
        public GetCompletedPayInfoResponseBody()
        {
        }
        
        public GetCompletedPayInfoResponseBody(string GetCompletedPayInfoResult)
        {
            this.GetCompletedPayInfoResult = GetCompletedPayInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCompletedPayDetailInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCompletedPayDetailInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetCompletedPayDetailInfoRequestBody Body;
        
        public GetCompletedPayDetailInfoRequest()
        {
        }
        
        public GetCompletedPayDetailInfoRequest(JHWR.GetCompletedPayDetailInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCompletedPayDetailInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetCompletedPayDetailInfoRequestBody()
        {
        }
        
        public GetCompletedPayDetailInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCompletedPayDetailInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCompletedPayDetailInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetCompletedPayDetailInfoResponseBody Body;
        
        public GetCompletedPayDetailInfoResponse()
        {
        }
        
        public GetCompletedPayDetailInfoResponse(JHWR.GetCompletedPayDetailInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCompletedPayDetailInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCompletedPayDetailInfoResult;
        
        public GetCompletedPayDetailInfoResponseBody()
        {
        }
        
        public GetCompletedPayDetailInfoResponseBody(string GetCompletedPayDetailInfoResult)
        {
            this.GetCompletedPayDetailInfoResult = GetCompletedPayDetailInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMedPriceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMedPrice", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetMedPriceRequestBody Body;
        
        public GetMedPriceRequest()
        {
        }
        
        public GetMedPriceRequest(JHWR.GetMedPriceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMedPriceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetMedPriceRequestBody()
        {
        }
        
        public GetMedPriceRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMedPriceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMedPriceResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetMedPriceResponseBody Body;
        
        public GetMedPriceResponse()
        {
        }
        
        public GetMedPriceResponse(JHWR.GetMedPriceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMedPriceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetMedPriceResult;
        
        public GetMedPriceResponseBody()
        {
        }
        
        public GetMedPriceResponseBody(string GetMedPriceResult)
        {
            this.GetMedPriceResult = GetMedPriceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTarItemPriceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTarItemPrice", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetTarItemPriceRequestBody Body;
        
        public GetTarItemPriceRequest()
        {
        }
        
        public GetTarItemPriceRequest(JHWR.GetTarItemPriceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTarItemPriceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetTarItemPriceRequestBody()
        {
        }
        
        public GetTarItemPriceRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTarItemPriceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTarItemPriceResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetTarItemPriceResponseBody Body;
        
        public GetTarItemPriceResponse()
        {
        }
        
        public GetTarItemPriceResponse(JHWR.GetTarItemPriceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTarItemPriceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetTarItemPriceResult;
        
        public GetTarItemPriceResponseBody()
        {
        }
        
        public GetTarItemPriceResponseBody(string GetTarItemPriceResult)
        {
            this.GetTarItemPriceResult = GetTarItemPriceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindPatientCardRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindPatientCard", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.FindPatientCardRequestBody Body;
        
        public FindPatientCardRequest()
        {
        }
        
        public FindPatientCardRequest(JHWR.FindPatientCardRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindPatientCardRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public FindPatientCardRequestBody()
        {
        }
        
        public FindPatientCardRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindPatientCardResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindPatientCardResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.FindPatientCardResponseBody Body;
        
        public FindPatientCardResponse()
        {
        }
        
        public FindPatientCardResponse(JHWR.FindPatientCardResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindPatientCardResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindPatientCardResult;
        
        public FindPatientCardResponseBody()
        {
        }
        
        public FindPatientCardResponseBody(string FindPatientCardResult)
        {
            this.FindPatientCardResult = FindPatientCardResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SavePatientCardRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SavePatientCard", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.SavePatientCardRequestBody Body;
        
        public SavePatientCardRequest()
        {
        }
        
        public SavePatientCardRequest(JHWR.SavePatientCardRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SavePatientCardRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public SavePatientCardRequestBody()
        {
        }
        
        public SavePatientCardRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SavePatientCardResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SavePatientCardResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.SavePatientCardResponseBody Body;
        
        public SavePatientCardResponse()
        {
        }
        
        public SavePatientCardResponse(JHWR.SavePatientCardResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SavePatientCardResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SavePatientCardResult;
        
        public SavePatientCardResponseBody()
        {
        }
        
        public SavePatientCardResponseBody(string SavePatientCardResult)
        {
            this.SavePatientCardResult = SavePatientCardResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BookServiceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BookService", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.BookServiceRequestBody Body;
        
        public BookServiceRequest()
        {
        }
        
        public BookServiceRequest(JHWR.BookServiceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BookServiceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public BookServiceRequestBody()
        {
        }
        
        public BookServiceRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BookServiceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BookServiceResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.BookServiceResponseBody Body;
        
        public BookServiceResponse()
        {
        }
        
        public BookServiceResponse(JHWR.BookServiceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BookServiceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BookServiceResult;
        
        public BookServiceResponseBody()
        {
        }
        
        public BookServiceResponseBody(string BookServiceResult)
        {
            this.BookServiceResult = BookServiceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryOrderRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryOrder", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryOrderRequestBody Body;
        
        public QueryOrderRequest()
        {
        }
        
        public QueryOrderRequest(JHWR.QueryOrderRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryOrderRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public QueryOrderRequestBody()
        {
        }
        
        public QueryOrderRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryOrderResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryOrderResponseBody Body;
        
        public QueryOrderResponse()
        {
        }
        
        public QueryOrderResponse(JHWR.QueryOrderResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryOrderResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string QueryOrderResult;
        
        public QueryOrderResponseBody()
        {
        }
        
        public QueryOrderResponseBody(string QueryOrderResult)
        {
            this.QueryOrderResult = QueryOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelOrderRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CancelOrder", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.CancelOrderRequestBody Body;
        
        public CancelOrderRequest()
        {
        }
        
        public CancelOrderRequest(JHWR.CancelOrderRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CancelOrderRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public CancelOrderRequestBody()
        {
        }
        
        public CancelOrderRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelOrderResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CancelOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.CancelOrderResponseBody Body;
        
        public CancelOrderResponse()
        {
        }
        
        public CancelOrderResponse(JHWR.CancelOrderResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CancelOrderResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CancelOrderResult;
        
        public CancelOrderResponseBody()
        {
        }
        
        public CancelOrderResponseBody(string CancelOrderResult)
        {
            this.CancelOrderResult = CancelOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OPAppArriveRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OPAppArrive", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.OPAppArriveRequestBody Body;
        
        public OPAppArriveRequest()
        {
        }
        
        public OPAppArriveRequest(JHWR.OPAppArriveRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OPAppArriveRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public OPAppArriveRequestBody()
        {
        }
        
        public OPAppArriveRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OPAppArriveResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OPAppArriveResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.OPAppArriveResponseBody Body;
        
        public OPAppArriveResponse()
        {
        }
        
        public OPAppArriveResponse(JHWR.OPAppArriveResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OPAppArriveResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string OPAppArriveResult;
        
        public OPAppArriveResponseBody()
        {
        }
        
        public OPAppArriveResponseBody(string OPAppArriveResult)
        {
            this.OPAppArriveResult = OPAppArriveResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPPatAdmInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPPatAdmInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPPatAdmInfoRequestBody Body;
        
        public GetIPPatAdmInfoRequest()
        {
        }
        
        public GetIPPatAdmInfoRequest(JHWR.GetIPPatAdmInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPPatAdmInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetIPPatAdmInfoRequestBody()
        {
        }
        
        public GetIPPatAdmInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPPatAdmInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPPatAdmInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPPatAdmInfoResponseBody Body;
        
        public GetIPPatAdmInfoResponse()
        {
        }
        
        public GetIPPatAdmInfoResponse(JHWR.GetIPPatAdmInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPPatAdmInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIPPatAdmInfoResult;
        
        public GetIPPatAdmInfoResponseBody()
        {
        }
        
        public GetIPPatAdmInfoResponseBody(string GetIPPatAdmInfoResult)
        {
            this.GetIPPatAdmInfoResult = GetIPPatAdmInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPPatientInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPPatientInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPPatientInfoRequestBody Body;
        
        public GetIPPatientInfoRequest()
        {
        }
        
        public GetIPPatientInfoRequest(JHWR.GetIPPatientInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPPatientInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetIPPatientInfoRequestBody()
        {
        }
        
        public GetIPPatientInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPPatientInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPPatientInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPPatientInfoResponseBody Body;
        
        public GetIPPatientInfoResponse()
        {
        }
        
        public GetIPPatientInfoResponse(JHWR.GetIPPatientInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPPatientInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIPPatientInfoResult;
        
        public GetIPPatientInfoResponseBody()
        {
        }
        
        public GetIPPatientInfoResponseBody(string GetIPPatientInfoResult)
        {
            this.GetIPPatientInfoResult = GetIPPatientInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddIPDepositRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddIPDeposit", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AddIPDepositRequestBody Body;
        
        public AddIPDepositRequest()
        {
        }
        
        public AddIPDepositRequest(JHWR.AddIPDepositRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddIPDepositRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public AddIPDepositRequestBody()
        {
        }
        
        public AddIPDepositRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddIPDepositResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddIPDepositResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AddIPDepositResponseBody Body;
        
        public AddIPDepositResponse()
        {
        }
        
        public AddIPDepositResponse(JHWR.AddIPDepositResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddIPDepositResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddIPDepositResult;
        
        public AddIPDepositResponseBody()
        {
        }
        
        public AddIPDepositResponseBody(string AddIPDepositResult)
        {
            this.AddIPDepositResult = AddIPDepositResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDepPayRecordRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDepPayRecord", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetDepPayRecordRequestBody Body;
        
        public GetDepPayRecordRequest()
        {
        }
        
        public GetDepPayRecordRequest(JHWR.GetDepPayRecordRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDepPayRecordRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetDepPayRecordRequestBody()
        {
        }
        
        public GetDepPayRecordRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDepPayRecordResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDepPayRecordResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetDepPayRecordResponseBody Body;
        
        public GetDepPayRecordResponse()
        {
        }
        
        public GetDepPayRecordResponse(JHWR.GetDepPayRecordResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDepPayRecordResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetDepPayRecordResult;
        
        public GetDepPayRecordResponseBody()
        {
        }
        
        public GetDepPayRecordResponseBody(string GetDepPayRecordResult)
        {
            this.GetDepPayRecordResult = GetDepPayRecordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPDepositRecordRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPDepositRecord", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPDepositRecordRequestBody Body;
        
        public GetIPDepositRecordRequest()
        {
        }
        
        public GetIPDepositRecordRequest(JHWR.GetIPDepositRecordRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPDepositRecordRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetIPDepositRecordRequestBody()
        {
        }
        
        public GetIPDepositRecordRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPDepositRecordResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPDepositRecordResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPDepositRecordResponseBody Body;
        
        public GetIPDepositRecordResponse()
        {
        }
        
        public GetIPDepositRecordResponse(JHWR.GetIPDepositRecordResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPDepositRecordResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIPDepositRecordResult;
        
        public GetIPDepositRecordResponseBody()
        {
        }
        
        public GetIPDepositRecordResponseBody(string GetIPDepositRecordResult)
        {
            this.GetIPDepositRecordResult = GetIPDepositRecordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPDailyBillRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPDailyBill", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPDailyBillRequestBody Body;
        
        public GetIPDailyBillRequest()
        {
        }
        
        public GetIPDailyBillRequest(JHWR.GetIPDailyBillRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPDailyBillRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetIPDailyBillRequestBody()
        {
        }
        
        public GetIPDailyBillRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPDailyBillResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPDailyBillResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPDailyBillResponseBody Body;
        
        public GetIPDailyBillResponse()
        {
        }
        
        public GetIPDailyBillResponse(JHWR.GetIPDailyBillResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPDailyBillResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIPDailyBillResult;
        
        public GetIPDailyBillResponseBody()
        {
        }
        
        public GetIPDailyBillResponseBody(string GetIPDailyBillResult)
        {
            this.GetIPDailyBillResult = GetIPDailyBillResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPTotalCostRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPTotalCost", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPTotalCostRequestBody Body;
        
        public GetIPTotalCostRequest()
        {
        }
        
        public GetIPTotalCostRequest(JHWR.GetIPTotalCostRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPTotalCostRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetIPTotalCostRequestBody()
        {
        }
        
        public GetIPTotalCostRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPTotalCostResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPTotalCostResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPTotalCostResponseBody Body;
        
        public GetIPTotalCostResponse()
        {
        }
        
        public GetIPTotalCostResponse(JHWR.GetIPTotalCostResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPTotalCostResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIPTotalCostResult;
        
        public GetIPTotalCostResponseBody()
        {
        }
        
        public GetIPTotalCostResponseBody(string GetIPTotalCostResult)
        {
            this.GetIPTotalCostResult = GetIPTotalCostResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPDetailCostRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPDetailCost", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPDetailCostRequestBody Body;
        
        public GetIPDetailCostRequest()
        {
        }
        
        public GetIPDetailCostRequest(JHWR.GetIPDetailCostRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPDetailCostRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetIPDetailCostRequestBody()
        {
        }
        
        public GetIPDetailCostRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPDetailCostResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPDetailCostResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPDetailCostResponseBody Body;
        
        public GetIPDetailCostResponse()
        {
        }
        
        public GetIPDetailCostResponse(JHWR.GetIPDetailCostResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPDetailCostResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIPDetailCostResult;
        
        public GetIPDetailCostResponseBody()
        {
        }
        
        public GetIPDetailCostResponseBody(string GetIPDetailCostResult)
        {
            this.GetIPDetailCostResult = GetIPDetailCostResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPAdmInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPAdmInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPAdmInfoRequestBody Body;
        
        public GetIPAdmInfoRequest()
        {
        }
        
        public GetIPAdmInfoRequest(JHWR.GetIPAdmInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPAdmInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetIPAdmInfoRequestBody()
        {
        }
        
        public GetIPAdmInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIPAdmInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIPAdmInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetIPAdmInfoResponseBody Body;
        
        public GetIPAdmInfoResponse()
        {
        }
        
        public GetIPAdmInfoResponse(JHWR.GetIPAdmInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIPAdmInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIPAdmInfoResult;
        
        public GetIPAdmInfoResponseBody()
        {
        }
        
        public GetIPAdmInfoResponseBody(string GetIPAdmInfoResult)
        {
            this.GetIPAdmInfoResult = GetIPAdmInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckBillFeeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckBillFee", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.CheckBillFeeRequestBody Body;
        
        public CheckBillFeeRequest()
        {
        }
        
        public CheckBillFeeRequest(JHWR.CheckBillFeeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckBillFeeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public CheckBillFeeRequestBody()
        {
        }
        
        public CheckBillFeeRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckBillFeeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckBillFeeResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.CheckBillFeeResponseBody Body;
        
        public CheckBillFeeResponse()
        {
        }
        
        public CheckBillFeeResponse(JHWR.CheckBillFeeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckBillFeeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CheckBillFeeResult;
        
        public CheckBillFeeResponseBody()
        {
        }
        
        public CheckBillFeeResponseBody(string CheckBillFeeResult)
        {
            this.CheckBillFeeResult = CheckBillFeeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IPBillPayRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IPBillPay", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.IPBillPayRequestBody Body;
        
        public IPBillPayRequest()
        {
        }
        
        public IPBillPayRequest(JHWR.IPBillPayRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IPBillPayRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public IPBillPayRequestBody()
        {
        }
        
        public IPBillPayRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IPBillPayResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IPBillPayResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.IPBillPayResponseBody Body;
        
        public IPBillPayResponse()
        {
        }
        
        public IPBillPayResponse(JHWR.IPBillPayResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IPBillPayResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string IPBillPayResult;
        
        public IPBillPayResponseBody()
        {
        }
        
        public IPBillPayResponseBody(string IPBillPayResult)
        {
            this.IPBillPayResult = IPBillPayResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PayResultRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PayResult", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.PayResultRequestBody Body;
        
        public PayResultRequest()
        {
        }
        
        public PayResultRequest(JHWR.PayResultRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PayResultRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public PayResultRequestBody()
        {
        }
        
        public PayResultRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PayResultResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PayResultResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.PayResultResponseBody Body;
        
        public PayResultResponse()
        {
        }
        
        public PayResultResponse(JHWR.PayResultResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PayResultResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PayResultResult;
        
        public PayResultResponseBody()
        {
        }
        
        public PayResultResponseBody(string PayResultResult)
        {
            this.PayResultResult = PayResultResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTodayPrintListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTodayPrintList", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetTodayPrintListRequestBody Body;
        
        public GetTodayPrintListRequest()
        {
        }
        
        public GetTodayPrintListRequest(JHWR.GetTodayPrintListRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTodayPrintListRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetTodayPrintListRequestBody()
        {
        }
        
        public GetTodayPrintListRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTodayPrintListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTodayPrintListResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetTodayPrintListResponseBody Body;
        
        public GetTodayPrintListResponse()
        {
        }
        
        public GetTodayPrintListResponse(JHWR.GetTodayPrintListResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTodayPrintListResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetTodayPrintListResult;
        
        public GetTodayPrintListResponseBody()
        {
        }
        
        public GetTodayPrintListResponseBody(string GetTodayPrintListResult)
        {
            this.GetTodayPrintListResult = GetTodayPrintListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoZZJDailyReportRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoZZJDailyReport", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AutoZZJDailyReportRequestBody Body;
        
        public AutoZZJDailyReportRequest()
        {
        }
        
        public AutoZZJDailyReportRequest(JHWR.AutoZZJDailyReportRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AutoZZJDailyReportRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public AutoZZJDailyReportRequestBody()
        {
        }
        
        public AutoZZJDailyReportRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AutoZZJDailyReportResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AutoZZJDailyReportResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.AutoZZJDailyReportResponseBody Body;
        
        public AutoZZJDailyReportResponse()
        {
        }
        
        public AutoZZJDailyReportResponse(JHWR.AutoZZJDailyReportResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AutoZZJDailyReportResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AutoZZJDailyReportResult;
        
        public AutoZZJDailyReportResponseBody()
        {
        }
        
        public AutoZZJDailyReportResponseBody(string AutoZZJDailyReportResult)
        {
            this.AutoZZJDailyReportResult = AutoZZJDailyReportResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PrintRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Print", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.PrintRequestBody Body;
        
        public PrintRequest()
        {
        }
        
        public PrintRequest(JHWR.PrintRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PrintRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ob1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string obj2;
        
        public PrintRequestBody()
        {
        }
        
        public PrintRequestBody(string ob1, string obj2)
        {
            this.ob1 = ob1;
            this.obj2 = obj2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PrintResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PrintResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.PrintResponseBody Body;
        
        public PrintResponse()
        {
        }
        
        public PrintResponse(JHWR.PrintResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PrintResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PrintResult;
        
        public PrintResponseBody()
        {
        }
        
        public PrintResponseBody(string PrintResult)
        {
            this.PrintResult = PrintResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRPTInfoByPatientNoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRPTInfoByPatientNo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetRPTInfoByPatientNoRequestBody Body;
        
        public GetRPTInfoByPatientNoRequest()
        {
        }
        
        public GetRPTInfoByPatientNoRequest(JHWR.GetRPTInfoByPatientNoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRPTInfoByPatientNoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetRPTInfoByPatientNoRequestBody()
        {
        }
        
        public GetRPTInfoByPatientNoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRPTInfoByPatientNoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRPTInfoByPatientNoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetRPTInfoByPatientNoResponseBody Body;
        
        public GetRPTInfoByPatientNoResponse()
        {
        }
        
        public GetRPTInfoByPatientNoResponse(JHWR.GetRPTInfoByPatientNoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRPTInfoByPatientNoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetRPTInfoByPatientNoResult;
        
        public GetRPTInfoByPatientNoResponseBody()
        {
        }
        
        public GetRPTInfoByPatientNoResponseBody(string GetRPTInfoByPatientNoResult)
        {
            this.GetRPTInfoByPatientNoResult = GetRPTInfoByPatientNoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdatePrintSignByRptIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdatePrintSignByRptId", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.UpdatePrintSignByRptIdRequestBody Body;
        
        public UpdatePrintSignByRptIdRequest()
        {
        }
        
        public UpdatePrintSignByRptIdRequest(JHWR.UpdatePrintSignByRptIdRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdatePrintSignByRptIdRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public UpdatePrintSignByRptIdRequestBody()
        {
        }
        
        public UpdatePrintSignByRptIdRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdatePrintSignByRptIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdatePrintSignByRptIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.UpdatePrintSignByRptIdResponseBody Body;
        
        public UpdatePrintSignByRptIdResponse()
        {
        }
        
        public UpdatePrintSignByRptIdResponse(JHWR.UpdatePrintSignByRptIdResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdatePrintSignByRptIdResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdatePrintSignByRptIdResult;
        
        public UpdatePrintSignByRptIdResponseBody()
        {
        }
        
        public UpdatePrintSignByRptIdResponseBody(string UpdatePrintSignByRptIdResult)
        {
            this.UpdatePrintSignByRptIdResult = UpdatePrintSignByRptIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryDepartmentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryDepartment", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryDepartmentRequestBody Body;
        
        public QueryDepartmentRequest()
        {
        }
        
        public QueryDepartmentRequest(JHWR.QueryDepartmentRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryDepartmentRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public QueryDepartmentRequestBody()
        {
        }
        
        public QueryDepartmentRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryDepartmentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryDepartmentResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryDepartmentResponseBody Body;
        
        public QueryDepartmentResponse()
        {
        }
        
        public QueryDepartmentResponse(JHWR.QueryDepartmentResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryDepartmentResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string QueryDepartmentResult;
        
        public QueryDepartmentResponseBody()
        {
        }
        
        public QueryDepartmentResponseBody(string QueryDepartmentResult)
        {
            this.QueryDepartmentResult = QueryDepartmentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryAdmScheduleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryAdmSchedule", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryAdmScheduleRequestBody Body;
        
        public QueryAdmScheduleRequest()
        {
        }
        
        public QueryAdmScheduleRequest(JHWR.QueryAdmScheduleRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryAdmScheduleRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public QueryAdmScheduleRequestBody()
        {
        }
        
        public QueryAdmScheduleRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryAdmScheduleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryAdmScheduleResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryAdmScheduleResponseBody Body;
        
        public QueryAdmScheduleResponse()
        {
        }
        
        public QueryAdmScheduleResponse(JHWR.QueryAdmScheduleResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryAdmScheduleResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string QueryAdmScheduleResult;
        
        public QueryAdmScheduleResponseBody()
        {
        }
        
        public QueryAdmScheduleResponseBody(string QueryAdmScheduleResult)
        {
            this.QueryAdmScheduleResult = QueryAdmScheduleResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInsuRegParaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInsuRegPara", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetInsuRegParaRequestBody Body;
        
        public GetInsuRegParaRequest()
        {
        }
        
        public GetInsuRegParaRequest(JHWR.GetInsuRegParaRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInsuRegParaRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public GetInsuRegParaRequestBody()
        {
        }
        
        public GetInsuRegParaRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInsuRegParaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInsuRegParaResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.GetInsuRegParaResponseBody Body;
        
        public GetInsuRegParaResponse()
        {
        }
        
        public GetInsuRegParaResponse(JHWR.GetInsuRegParaResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInsuRegParaResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetInsuRegParaResult;
        
        public GetInsuRegParaResponseBody()
        {
        }
        
        public GetInsuRegParaResponseBody(string GetInsuRegParaResult)
        {
            this.GetInsuRegParaResult = GetInsuRegParaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LockOrderRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LockOrder", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.LockOrderRequestBody Body;
        
        public LockOrderRequest()
        {
        }
        
        public LockOrderRequest(JHWR.LockOrderRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LockOrderRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public LockOrderRequestBody()
        {
        }
        
        public LockOrderRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LockOrderResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LockOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.LockOrderResponseBody Body;
        
        public LockOrderResponse()
        {
        }
        
        public LockOrderResponse(JHWR.LockOrderResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LockOrderResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LockOrderResult;
        
        public LockOrderResponseBody()
        {
        }
        
        public LockOrderResponseBody(string LockOrderResult)
        {
            this.LockOrderResult = LockOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OPRegisterRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OPRegister", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.OPRegisterRequestBody Body;
        
        public OPRegisterRequest()
        {
        }
        
        public OPRegisterRequest(JHWR.OPRegisterRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OPRegisterRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public OPRegisterRequestBody()
        {
        }
        
        public OPRegisterRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OPRegisterResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OPRegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.OPRegisterResponseBody Body;
        
        public OPRegisterResponse()
        {
        }
        
        public OPRegisterResponse(JHWR.OPRegisterResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OPRegisterResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string OPRegisterResult;
        
        public OPRegisterResponseBody()
        {
        }
        
        public OPRegisterResponseBody(string OPRegisterResult)
        {
            this.OPRegisterResult = OPRegisterResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryAdmOPRegRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryAdmOPReg", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryAdmOPRegRequestBody Body;
        
        public QueryAdmOPRegRequest()
        {
        }
        
        public QueryAdmOPRegRequest(JHWR.QueryAdmOPRegRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryAdmOPRegRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public QueryAdmOPRegRequestBody()
        {
        }
        
        public QueryAdmOPRegRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryAdmOPRegResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryAdmOPRegResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryAdmOPRegResponseBody Body;
        
        public QueryAdmOPRegResponse()
        {
        }
        
        public QueryAdmOPRegResponse(JHWR.QueryAdmOPRegResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryAdmOPRegResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string QueryAdmOPRegResult;
        
        public QueryAdmOPRegResponseBody()
        {
        }
        
        public QueryAdmOPRegResponseBody(string QueryAdmOPRegResult)
        {
            this.QueryAdmOPRegResult = QueryAdmOPRegResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindCheckOrderByTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindCheckOrderByType", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.FindCheckOrderByTypeRequestBody Body;
        
        public FindCheckOrderByTypeRequest()
        {
        }
        
        public FindCheckOrderByTypeRequest(JHWR.FindCheckOrderByTypeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindCheckOrderByTypeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public FindCheckOrderByTypeRequestBody()
        {
        }
        
        public FindCheckOrderByTypeRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindCheckOrderByTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindCheckOrderByTypeResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.FindCheckOrderByTypeResponseBody Body;
        
        public FindCheckOrderByTypeResponse()
        {
        }
        
        public FindCheckOrderByTypeResponse(JHWR.FindCheckOrderByTypeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindCheckOrderByTypeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindCheckOrderByTypeResult;
        
        public FindCheckOrderByTypeResponseBody()
        {
        }
        
        public FindCheckOrderByTypeResponseBody(string FindCheckOrderByTypeResult)
        {
            this.FindCheckOrderByTypeResult = FindCheckOrderByTypeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveCheckOrderRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveCheckOrder", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.SaveCheckOrderRequestBody Body;
        
        public SaveCheckOrderRequest()
        {
        }
        
        public SaveCheckOrderRequest(JHWR.SaveCheckOrderRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveCheckOrderRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public SaveCheckOrderRequestBody()
        {
        }
        
        public SaveCheckOrderRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveCheckOrderResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveCheckOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.SaveCheckOrderResponseBody Body;
        
        public SaveCheckOrderResponse()
        {
        }
        
        public SaveCheckOrderResponse(JHWR.SaveCheckOrderResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveCheckOrderResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SaveCheckOrderResult;
        
        public SaveCheckOrderResponseBody()
        {
        }
        
        public SaveCheckOrderResponseBody(string SaveCheckOrderResult)
        {
            this.SaveCheckOrderResult = SaveCheckOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryScheduleTimeInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryScheduleTimeInfo", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryScheduleTimeInfoRequestBody Body;
        
        public QueryScheduleTimeInfoRequest()
        {
        }
        
        public QueryScheduleTimeInfoRequest(JHWR.QueryScheduleTimeInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryScheduleTimeInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InValue;
        
        public QueryScheduleTimeInfoRequestBody()
        {
        }
        
        public QueryScheduleTimeInfoRequestBody(string InValue)
        {
            this.InValue = InValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryScheduleTimeInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryScheduleTimeInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public JHWR.QueryScheduleTimeInfoResponseBody Body;
        
        public QueryScheduleTimeInfoResponse()
        {
        }
        
        public QueryScheduleTimeInfoResponse(JHWR.QueryScheduleTimeInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryScheduleTimeInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string QueryScheduleTimeInfoResult;
        
        public QueryScheduleTimeInfoResponseBody()
        {
        }
        
        public QueryScheduleTimeInfoResponseBody(string QueryScheduleTimeInfoResult)
        {
            this.QueryScheduleTimeInfoResult = QueryScheduleTimeInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface CallServiceSoapClientJHWRSoapChannel : JHWR.CallServiceSoapClientJHWRSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class CallServiceSoapClientJHWRSoapClient : System.ServiceModel.ClientBase<JHWR.CallServiceSoapClientJHWRSoap>, JHWR.CallServiceSoapClientJHWRSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CallServiceSoapClientJHWRSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CallServiceSoapClientJHWRSoapClient.GetBindingForEndpoint(endpointConfiguration), CallServiceSoapClientJHWRSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallServiceSoapClientJHWRSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CallServiceSoapClientJHWRSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallServiceSoapClientJHWRSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CallServiceSoapClientJHWRSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallServiceSoapClientJHWRSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.HelloWorldResponse> JHWR.CallServiceSoapClientJHWRSoap.HelloWorldAsync(JHWR.HelloWorldRequest request)
        {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.HelloWorldResponse> HelloWorldAsync()
        {
            JHWR.HelloWorldRequest inValue = new JHWR.HelloWorldRequest();
            inValue.Body = new JHWR.HelloWorldRequestBody();
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.DoTransResponse> JHWR.CallServiceSoapClientJHWRSoap.DoTransAsync(JHWR.DoTransRequest request)
        {
            return base.Channel.DoTransAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.DoTransResponse> DoTransAsync(string transCode, string inJsonString)
        {
            JHWR.DoTransRequest inValue = new JHWR.DoTransRequest();
            inValue.Body = new JHWR.DoTransRequestBody();
            inValue.Body.transCode = transCode;
            inValue.Body.inJsonString = inJsonString;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).DoTransAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.OPAutoPaymentResponse> JHWR.CallServiceSoapClientJHWRSoap.OPAutoPaymentAsync(JHWR.OPAutoPaymentRequest request)
        {
            return base.Channel.OPAutoPaymentAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.OPAutoPaymentResponse> OPAutoPaymentAsync(string InValue)
        {
            JHWR.OPAutoPaymentRequest inValue = new JHWR.OPAutoPaymentRequest();
            inValue.Body = new JHWR.OPAutoPaymentRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).OPAutoPaymentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.getScanPayQRResponse> JHWR.CallServiceSoapClientJHWRSoap.getScanPayQRAsync(JHWR.getScanPayQRRequest request)
        {
            return base.Channel.getScanPayQRAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.getScanPayQRResponse> getScanPayQRAsync(string InValue)
        {
            JHWR.getScanPayQRRequest inValue = new JHWR.getScanPayQRRequest();
            inValue.Body = new JHWR.getScanPayQRRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).getScanPayQRAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.ScanPayQueryResponse> JHWR.CallServiceSoapClientJHWRSoap.ScanPayQueryAsync(JHWR.ScanPayQueryRequest request)
        {
            return base.Channel.ScanPayQueryAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.ScanPayQueryResponse> ScanPayQueryAsync(string InValue)
        {
            JHWR.ScanPayQueryRequest inValue = new JHWR.ScanPayQueryRequest();
            inValue.Body = new JHWR.ScanPayQueryRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).ScanPayQueryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.runserviceResponse> JHWR.CallServiceSoapClientJHWRSoap.runserviceAsync(JHWR.runserviceRequest request)
        {
            return base.Channel.runserviceAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.runserviceResponse> runserviceAsync(string InValue)
        {
            JHWR.runserviceRequest inValue = new JHWR.runserviceRequest();
            inValue.Body = new JHWR.runserviceRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).runserviceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.SelfRegServiceResponse> JHWR.CallServiceSoapClientJHWRSoap.SelfRegServiceAsync(JHWR.SelfRegServiceRequest request)
        {
            return base.Channel.SelfRegServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.SelfRegServiceResponse> SelfRegServiceAsync(string requestCode, string InValue)
        {
            JHWR.SelfRegServiceRequest inValue = new JHWR.SelfRegServiceRequest();
            inValue.Body = new JHWR.SelfRegServiceRequestBody();
            inValue.Body.requestCode = requestCode;
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).SelfRegServiceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetINVImageResponse> JHWR.CallServiceSoapClientJHWRSoap.GetINVImageAsync(JHWR.GetINVImageRequest request)
        {
            return base.Channel.GetINVImageAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetINVImageResponse> GetINVImageAsync(string InValue)
        {
            JHWR.GetINVImageRequest inValue = new JHWR.GetINVImageRequest();
            inValue.Body = new JHWR.GetINVImageRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetINVImageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetPatInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetPatInfoAsync(JHWR.GetPatInfoRequest request)
        {
            return base.Channel.GetPatInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetPatInfoResponse> GetPatInfoAsync(string InValue)
        {
            JHWR.GetPatInfoRequest inValue = new JHWR.GetPatInfoRequest();
            inValue.Body = new JHWR.GetPatInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetPatInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.AddOPDepositResponse> JHWR.CallServiceSoapClientJHWRSoap.AddOPDepositAsync(JHWR.AddOPDepositRequest request)
        {
            return base.Channel.AddOPDepositAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.AddOPDepositResponse> AddOPDepositAsync(string InValue)
        {
            JHWR.AddOPDepositRequest inValue = new JHWR.AddOPDepositRequest();
            inValue.Body = new JHWR.AddOPDepositRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).AddOPDepositAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetOPAccPreDepositResponse> JHWR.CallServiceSoapClientJHWRSoap.GetOPAccPreDepositAsync(JHWR.GetOPAccPreDepositRequest request)
        {
            return base.Channel.GetOPAccPreDepositAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetOPAccPreDepositResponse> GetOPAccPreDepositAsync(string InValue)
        {
            JHWR.GetOPAccPreDepositRequest inValue = new JHWR.GetOPAccPreDepositRequest();
            inValue.Body = new JHWR.GetOPAccPreDepositRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetOPAccPreDepositAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetAccPayListResponse> JHWR.CallServiceSoapClientJHWRSoap.GetAccPayListAsync(JHWR.GetAccPayListRequest request)
        {
            return base.Channel.GetAccPayListAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetAccPayListResponse> GetAccPayListAsync(string InValue)
        {
            JHWR.GetAccPayListRequest inValue = new JHWR.GetAccPayListRequest();
            inValue.Body = new JHWR.GetAccPayListRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetAccPayListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetAdmByCardNoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetAdmByCardNoAsync(JHWR.GetAdmByCardNoRequest request)
        {
            return base.Channel.GetAdmByCardNoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetAdmByCardNoResponse> GetAdmByCardNoAsync(string InValue)
        {
            JHWR.GetAdmByCardNoRequest inValue = new JHWR.GetAdmByCardNoRequest();
            inValue.Body = new JHWR.GetAdmByCardNoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetAdmByCardNoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetBillInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetBillInfoAsync(JHWR.GetBillInfoRequest request)
        {
            return base.Channel.GetBillInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetBillInfoResponse> GetBillInfoAsync(string InValue)
        {
            JHWR.GetBillInfoRequest inValue = new JHWR.GetBillInfoRequest();
            inValue.Body = new JHWR.GetBillInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetBillInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.AutoOPBillChargeResponse> JHWR.CallServiceSoapClientJHWRSoap.AutoOPBillChargeAsync(JHWR.AutoOPBillChargeRequest request)
        {
            return base.Channel.AutoOPBillChargeAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.AutoOPBillChargeResponse> AutoOPBillChargeAsync(string InValue)
        {
            JHWR.AutoOPBillChargeRequest inValue = new JHWR.AutoOPBillChargeRequest();
            inValue.Body = new JHWR.AutoOPBillChargeRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).AutoOPBillChargeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.InserBankTradeInfoSingleResponse> JHWR.CallServiceSoapClientJHWRSoap.InserBankTradeInfoSingleAsync(JHWR.InserBankTradeInfoSingleRequest request)
        {
            return base.Channel.InserBankTradeInfoSingleAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.InserBankTradeInfoSingleResponse> InserBankTradeInfoSingleAsync(string InValue)
        {
            JHWR.InserBankTradeInfoSingleRequest inValue = new JHWR.InserBankTradeInfoSingleRequest();
            inValue.Body = new JHWR.InserBankTradeInfoSingleRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).InserBankTradeInfoSingleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetOPInvTarDetailResponse> JHWR.CallServiceSoapClientJHWRSoap.GetOPInvTarDetailAsync(JHWR.GetOPInvTarDetailRequest request)
        {
            return base.Channel.GetOPInvTarDetailAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetOPInvTarDetailResponse> GetOPInvTarDetailAsync(string InValue)
        {
            JHWR.GetOPInvTarDetailRequest inValue = new JHWR.GetOPInvTarDetailRequest();
            inValue.Body = new JHWR.GetOPInvTarDetailRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetOPInvTarDetailAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetCompletedPayInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetCompletedPayInfoAsync(JHWR.GetCompletedPayInfoRequest request)
        {
            return base.Channel.GetCompletedPayInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetCompletedPayInfoResponse> GetCompletedPayInfoAsync(string InValue)
        {
            JHWR.GetCompletedPayInfoRequest inValue = new JHWR.GetCompletedPayInfoRequest();
            inValue.Body = new JHWR.GetCompletedPayInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetCompletedPayInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetCompletedPayDetailInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetCompletedPayDetailInfoAsync(JHWR.GetCompletedPayDetailInfoRequest request)
        {
            return base.Channel.GetCompletedPayDetailInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetCompletedPayDetailInfoResponse> GetCompletedPayDetailInfoAsync(string InValue)
        {
            JHWR.GetCompletedPayDetailInfoRequest inValue = new JHWR.GetCompletedPayDetailInfoRequest();
            inValue.Body = new JHWR.GetCompletedPayDetailInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetCompletedPayDetailInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetMedPriceResponse> JHWR.CallServiceSoapClientJHWRSoap.GetMedPriceAsync(JHWR.GetMedPriceRequest request)
        {
            return base.Channel.GetMedPriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetMedPriceResponse> GetMedPriceAsync(string InValue)
        {
            JHWR.GetMedPriceRequest inValue = new JHWR.GetMedPriceRequest();
            inValue.Body = new JHWR.GetMedPriceRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetMedPriceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetTarItemPriceResponse> JHWR.CallServiceSoapClientJHWRSoap.GetTarItemPriceAsync(JHWR.GetTarItemPriceRequest request)
        {
            return base.Channel.GetTarItemPriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetTarItemPriceResponse> GetTarItemPriceAsync(string InValue)
        {
            JHWR.GetTarItemPriceRequest inValue = new JHWR.GetTarItemPriceRequest();
            inValue.Body = new JHWR.GetTarItemPriceRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetTarItemPriceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.FindPatientCardResponse> JHWR.CallServiceSoapClientJHWRSoap.FindPatientCardAsync(JHWR.FindPatientCardRequest request)
        {
            return base.Channel.FindPatientCardAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.FindPatientCardResponse> FindPatientCardAsync(string InValue)
        {
            JHWR.FindPatientCardRequest inValue = new JHWR.FindPatientCardRequest();
            inValue.Body = new JHWR.FindPatientCardRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).FindPatientCardAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.SavePatientCardResponse> JHWR.CallServiceSoapClientJHWRSoap.SavePatientCardAsync(JHWR.SavePatientCardRequest request)
        {
            return base.Channel.SavePatientCardAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.SavePatientCardResponse> SavePatientCardAsync(string InValue)
        {
            JHWR.SavePatientCardRequest inValue = new JHWR.SavePatientCardRequest();
            inValue.Body = new JHWR.SavePatientCardRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).SavePatientCardAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.BookServiceResponse> JHWR.CallServiceSoapClientJHWRSoap.BookServiceAsync(JHWR.BookServiceRequest request)
        {
            return base.Channel.BookServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.BookServiceResponse> BookServiceAsync(string InValue)
        {
            JHWR.BookServiceRequest inValue = new JHWR.BookServiceRequest();
            inValue.Body = new JHWR.BookServiceRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).BookServiceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.QueryOrderResponse> JHWR.CallServiceSoapClientJHWRSoap.QueryOrderAsync(JHWR.QueryOrderRequest request)
        {
            return base.Channel.QueryOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.QueryOrderResponse> QueryOrderAsync(string InValue)
        {
            JHWR.QueryOrderRequest inValue = new JHWR.QueryOrderRequest();
            inValue.Body = new JHWR.QueryOrderRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).QueryOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.CancelOrderResponse> JHWR.CallServiceSoapClientJHWRSoap.CancelOrderAsync(JHWR.CancelOrderRequest request)
        {
            return base.Channel.CancelOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.CancelOrderResponse> CancelOrderAsync(string InValue)
        {
            JHWR.CancelOrderRequest inValue = new JHWR.CancelOrderRequest();
            inValue.Body = new JHWR.CancelOrderRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).CancelOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.OPAppArriveResponse> JHWR.CallServiceSoapClientJHWRSoap.OPAppArriveAsync(JHWR.OPAppArriveRequest request)
        {
            return base.Channel.OPAppArriveAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.OPAppArriveResponse> OPAppArriveAsync(string InValue)
        {
            JHWR.OPAppArriveRequest inValue = new JHWR.OPAppArriveRequest();
            inValue.Body = new JHWR.OPAppArriveRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).OPAppArriveAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetIPPatAdmInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetIPPatAdmInfoAsync(JHWR.GetIPPatAdmInfoRequest request)
        {
            return base.Channel.GetIPPatAdmInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetIPPatAdmInfoResponse> GetIPPatAdmInfoAsync(string InValue)
        {
            JHWR.GetIPPatAdmInfoRequest inValue = new JHWR.GetIPPatAdmInfoRequest();
            inValue.Body = new JHWR.GetIPPatAdmInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetIPPatAdmInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetIPPatientInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetIPPatientInfoAsync(JHWR.GetIPPatientInfoRequest request)
        {
            return base.Channel.GetIPPatientInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetIPPatientInfoResponse> GetIPPatientInfoAsync(string InValue)
        {
            JHWR.GetIPPatientInfoRequest inValue = new JHWR.GetIPPatientInfoRequest();
            inValue.Body = new JHWR.GetIPPatientInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetIPPatientInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.AddIPDepositResponse> JHWR.CallServiceSoapClientJHWRSoap.AddIPDepositAsync(JHWR.AddIPDepositRequest request)
        {
            return base.Channel.AddIPDepositAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.AddIPDepositResponse> AddIPDepositAsync(string InValue)
        {
            JHWR.AddIPDepositRequest inValue = new JHWR.AddIPDepositRequest();
            inValue.Body = new JHWR.AddIPDepositRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).AddIPDepositAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetDepPayRecordResponse> JHWR.CallServiceSoapClientJHWRSoap.GetDepPayRecordAsync(JHWR.GetDepPayRecordRequest request)
        {
            return base.Channel.GetDepPayRecordAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetDepPayRecordResponse> GetDepPayRecordAsync(string InValue)
        {
            JHWR.GetDepPayRecordRequest inValue = new JHWR.GetDepPayRecordRequest();
            inValue.Body = new JHWR.GetDepPayRecordRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetDepPayRecordAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetIPDepositRecordResponse> JHWR.CallServiceSoapClientJHWRSoap.GetIPDepositRecordAsync(JHWR.GetIPDepositRecordRequest request)
        {
            return base.Channel.GetIPDepositRecordAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetIPDepositRecordResponse> GetIPDepositRecordAsync(string InValue)
        {
            JHWR.GetIPDepositRecordRequest inValue = new JHWR.GetIPDepositRecordRequest();
            inValue.Body = new JHWR.GetIPDepositRecordRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetIPDepositRecordAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetIPDailyBillResponse> JHWR.CallServiceSoapClientJHWRSoap.GetIPDailyBillAsync(JHWR.GetIPDailyBillRequest request)
        {
            return base.Channel.GetIPDailyBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetIPDailyBillResponse> GetIPDailyBillAsync(string InValue)
        {
            JHWR.GetIPDailyBillRequest inValue = new JHWR.GetIPDailyBillRequest();
            inValue.Body = new JHWR.GetIPDailyBillRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetIPDailyBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetIPTotalCostResponse> JHWR.CallServiceSoapClientJHWRSoap.GetIPTotalCostAsync(JHWR.GetIPTotalCostRequest request)
        {
            return base.Channel.GetIPTotalCostAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetIPTotalCostResponse> GetIPTotalCostAsync(string InValue)
        {
            JHWR.GetIPTotalCostRequest inValue = new JHWR.GetIPTotalCostRequest();
            inValue.Body = new JHWR.GetIPTotalCostRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetIPTotalCostAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetIPDetailCostResponse> JHWR.CallServiceSoapClientJHWRSoap.GetIPDetailCostAsync(JHWR.GetIPDetailCostRequest request)
        {
            return base.Channel.GetIPDetailCostAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetIPDetailCostResponse> GetIPDetailCostAsync(string InValue)
        {
            JHWR.GetIPDetailCostRequest inValue = new JHWR.GetIPDetailCostRequest();
            inValue.Body = new JHWR.GetIPDetailCostRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetIPDetailCostAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetIPAdmInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetIPAdmInfoAsync(JHWR.GetIPAdmInfoRequest request)
        {
            return base.Channel.GetIPAdmInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetIPAdmInfoResponse> GetIPAdmInfoAsync(string InValue)
        {
            JHWR.GetIPAdmInfoRequest inValue = new JHWR.GetIPAdmInfoRequest();
            inValue.Body = new JHWR.GetIPAdmInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetIPAdmInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.CheckBillFeeResponse> JHWR.CallServiceSoapClientJHWRSoap.CheckBillFeeAsync(JHWR.CheckBillFeeRequest request)
        {
            return base.Channel.CheckBillFeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.CheckBillFeeResponse> CheckBillFeeAsync(string InValue)
        {
            JHWR.CheckBillFeeRequest inValue = new JHWR.CheckBillFeeRequest();
            inValue.Body = new JHWR.CheckBillFeeRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).CheckBillFeeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.IPBillPayResponse> JHWR.CallServiceSoapClientJHWRSoap.IPBillPayAsync(JHWR.IPBillPayRequest request)
        {
            return base.Channel.IPBillPayAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.IPBillPayResponse> IPBillPayAsync(string InValue)
        {
            JHWR.IPBillPayRequest inValue = new JHWR.IPBillPayRequest();
            inValue.Body = new JHWR.IPBillPayRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).IPBillPayAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.PayResultResponse> JHWR.CallServiceSoapClientJHWRSoap.PayResultAsync(JHWR.PayResultRequest request)
        {
            return base.Channel.PayResultAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.PayResultResponse> PayResultAsync(string InValue)
        {
            JHWR.PayResultRequest inValue = new JHWR.PayResultRequest();
            inValue.Body = new JHWR.PayResultRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).PayResultAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetTodayPrintListResponse> JHWR.CallServiceSoapClientJHWRSoap.GetTodayPrintListAsync(JHWR.GetTodayPrintListRequest request)
        {
            return base.Channel.GetTodayPrintListAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetTodayPrintListResponse> GetTodayPrintListAsync(string InValue)
        {
            JHWR.GetTodayPrintListRequest inValue = new JHWR.GetTodayPrintListRequest();
            inValue.Body = new JHWR.GetTodayPrintListRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetTodayPrintListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.AutoZZJDailyReportResponse> JHWR.CallServiceSoapClientJHWRSoap.AutoZZJDailyReportAsync(JHWR.AutoZZJDailyReportRequest request)
        {
            return base.Channel.AutoZZJDailyReportAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.AutoZZJDailyReportResponse> AutoZZJDailyReportAsync(string InValue)
        {
            JHWR.AutoZZJDailyReportRequest inValue = new JHWR.AutoZZJDailyReportRequest();
            inValue.Body = new JHWR.AutoZZJDailyReportRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).AutoZZJDailyReportAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.PrintResponse> JHWR.CallServiceSoapClientJHWRSoap.PrintAsync(JHWR.PrintRequest request)
        {
            return base.Channel.PrintAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.PrintResponse> PrintAsync(string ob1, string obj2)
        {
            JHWR.PrintRequest inValue = new JHWR.PrintRequest();
            inValue.Body = new JHWR.PrintRequestBody();
            inValue.Body.ob1 = ob1;
            inValue.Body.obj2 = obj2;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).PrintAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetRPTInfoByPatientNoResponse> JHWR.CallServiceSoapClientJHWRSoap.GetRPTInfoByPatientNoAsync(JHWR.GetRPTInfoByPatientNoRequest request)
        {
            return base.Channel.GetRPTInfoByPatientNoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetRPTInfoByPatientNoResponse> GetRPTInfoByPatientNoAsync(string InValue)
        {
            JHWR.GetRPTInfoByPatientNoRequest inValue = new JHWR.GetRPTInfoByPatientNoRequest();
            inValue.Body = new JHWR.GetRPTInfoByPatientNoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetRPTInfoByPatientNoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.UpdatePrintSignByRptIdResponse> JHWR.CallServiceSoapClientJHWRSoap.UpdatePrintSignByRptIdAsync(JHWR.UpdatePrintSignByRptIdRequest request)
        {
            return base.Channel.UpdatePrintSignByRptIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.UpdatePrintSignByRptIdResponse> UpdatePrintSignByRptIdAsync(string InValue)
        {
            JHWR.UpdatePrintSignByRptIdRequest inValue = new JHWR.UpdatePrintSignByRptIdRequest();
            inValue.Body = new JHWR.UpdatePrintSignByRptIdRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).UpdatePrintSignByRptIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.QueryDepartmentResponse> JHWR.CallServiceSoapClientJHWRSoap.QueryDepartmentAsync(JHWR.QueryDepartmentRequest request)
        {
            return base.Channel.QueryDepartmentAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.QueryDepartmentResponse> QueryDepartmentAsync(string InValue)
        {
            JHWR.QueryDepartmentRequest inValue = new JHWR.QueryDepartmentRequest();
            inValue.Body = new JHWR.QueryDepartmentRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).QueryDepartmentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.QueryAdmScheduleResponse> JHWR.CallServiceSoapClientJHWRSoap.QueryAdmScheduleAsync(JHWR.QueryAdmScheduleRequest request)
        {
            return base.Channel.QueryAdmScheduleAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.QueryAdmScheduleResponse> QueryAdmScheduleAsync(string InValue)
        {
            JHWR.QueryAdmScheduleRequest inValue = new JHWR.QueryAdmScheduleRequest();
            inValue.Body = new JHWR.QueryAdmScheduleRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).QueryAdmScheduleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.GetInsuRegParaResponse> JHWR.CallServiceSoapClientJHWRSoap.GetInsuRegParaAsync(JHWR.GetInsuRegParaRequest request)
        {
            return base.Channel.GetInsuRegParaAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.GetInsuRegParaResponse> GetInsuRegParaAsync(string InValue)
        {
            JHWR.GetInsuRegParaRequest inValue = new JHWR.GetInsuRegParaRequest();
            inValue.Body = new JHWR.GetInsuRegParaRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).GetInsuRegParaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.LockOrderResponse> JHWR.CallServiceSoapClientJHWRSoap.LockOrderAsync(JHWR.LockOrderRequest request)
        {
            return base.Channel.LockOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.LockOrderResponse> LockOrderAsync(string InValue)
        {
            JHWR.LockOrderRequest inValue = new JHWR.LockOrderRequest();
            inValue.Body = new JHWR.LockOrderRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).LockOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.OPRegisterResponse> JHWR.CallServiceSoapClientJHWRSoap.OPRegisterAsync(JHWR.OPRegisterRequest request)
        {
            return base.Channel.OPRegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.OPRegisterResponse> OPRegisterAsync(string InValue)
        {
            JHWR.OPRegisterRequest inValue = new JHWR.OPRegisterRequest();
            inValue.Body = new JHWR.OPRegisterRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).OPRegisterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.QueryAdmOPRegResponse> JHWR.CallServiceSoapClientJHWRSoap.QueryAdmOPRegAsync(JHWR.QueryAdmOPRegRequest request)
        {
            return base.Channel.QueryAdmOPRegAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.QueryAdmOPRegResponse> QueryAdmOPRegAsync(string InValue)
        {
            JHWR.QueryAdmOPRegRequest inValue = new JHWR.QueryAdmOPRegRequest();
            inValue.Body = new JHWR.QueryAdmOPRegRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).QueryAdmOPRegAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.FindCheckOrderByTypeResponse> JHWR.CallServiceSoapClientJHWRSoap.FindCheckOrderByTypeAsync(JHWR.FindCheckOrderByTypeRequest request)
        {
            return base.Channel.FindCheckOrderByTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.FindCheckOrderByTypeResponse> FindCheckOrderByTypeAsync(string InValue)
        {
            JHWR.FindCheckOrderByTypeRequest inValue = new JHWR.FindCheckOrderByTypeRequest();
            inValue.Body = new JHWR.FindCheckOrderByTypeRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).FindCheckOrderByTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.SaveCheckOrderResponse> JHWR.CallServiceSoapClientJHWRSoap.SaveCheckOrderAsync(JHWR.SaveCheckOrderRequest request)
        {
            return base.Channel.SaveCheckOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.SaveCheckOrderResponse> SaveCheckOrderAsync(string InValue)
        {
            JHWR.SaveCheckOrderRequest inValue = new JHWR.SaveCheckOrderRequest();
            inValue.Body = new JHWR.SaveCheckOrderRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).SaveCheckOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<JHWR.QueryScheduleTimeInfoResponse> JHWR.CallServiceSoapClientJHWRSoap.QueryScheduleTimeInfoAsync(JHWR.QueryScheduleTimeInfoRequest request)
        {
            return base.Channel.QueryScheduleTimeInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<JHWR.QueryScheduleTimeInfoResponse> QueryScheduleTimeInfoAsync(string InValue)
        {
            JHWR.QueryScheduleTimeInfoRequest inValue = new JHWR.QueryScheduleTimeInfoRequest();
            inValue.Body = new JHWR.QueryScheduleTimeInfoRequestBody();
            inValue.Body.InValue = InValue;
            return ((JHWR.CallServiceSoapClientJHWRSoap)(this)).QueryScheduleTimeInfoAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CallServiceSoapClientJHWRSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CallServiceSoapClientJHWRSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CallServiceSoapClientJHWRSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:35465/CallServiceSoapClientJHWR.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.CallServiceSoapClientJHWRSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:35465/CallServiceSoapClientJHWR.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            CallServiceSoapClientJHWRSoap,
            
            CallServiceSoapClientJHWRSoap12,
        }
    }
}
