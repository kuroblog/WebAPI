
namespace Flysh.HospInterface.ProxyApi.Services
{
    using Flysh.HospInterface.ProxyApi.His;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public interface IProxyService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, string data) HisTest<TData>(HospRequest<TData> request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, IEnumerable<ClassScheduleData> data) ClassSchedule(ClassScheduleRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, IEnumerable<string> data) ClassPoint(ClassPointRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, SubscribeSubmitData data) SubscribeSubmit(SubscribeSubmitRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, bool data) SubscribeCancel(SubscribeCancelRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, SubscribeQueryData data) SubscribeQuery(SubscribeQueryRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, RegisterSubmitData data) RegisterSubmit(RegisterSubmitRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, bool data) RegisterCancel(RegisterCancelRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, IEnumerable<FeeRecipeQueryData> data) FeeRegisterQuery(FeeRecipeQueryRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, IEnumerable<ReportQueryData> data) ReportQuery(ReportQueryRequest request);
    }

    /// <summary>
    /// 
    /// </summary>
    public class ProxyService : IProxyService
    {
        private readonly IHospProxyInterface service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proxyFactory"></param>
        public ProxyService(HisProxyFactory proxyFactory)
        {
            service = proxyFactory.Instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, string data) HisTest<TData>(HospRequest<TData> request)
        {
            var hisResultSource = service.Invoke(request);

            var rValue = true;
            var mValue = "";
            var dValue = hisResultSource.Result;

            return (rValue, mValue, dValue);
        }

        private Func<HisShemaInfo, ClassScheduleData> hisShemaInfoParser = (h) => new ClassScheduleData
        {
            adress = h.ADRESS,
            beginTime = h.BEGIN_TIME,
            deptCode = h.DEPT_CODE,
            deptName = h.DEPT_NAME,
            doctCode = h.DOCT_CODE,
            doctName = h.DOCT_NAME,
            endTime = h.END_TIME,
            classId = h.ID,
            nooncode = h.NOONCODE,
            regLevl = h.REGLEVL_NAME,
            regLmt = h.BOOKING_LMT,
            regReged = h.TEL_REGED,
            regType = h.REGISTRATION_TYPE,
            seeDate = h.SEE_DATE,
            totCost = h.TOT_COST,
            week = h.WEEK,
            hasReg = h.HASREG,
            itemCode = h.ITEMCODE,
            sortId = h.SORTID
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, IEnumerable<ClassScheduleData> data) ClassSchedule(ClassScheduleRequest request)
        {
            var result = Invoke<ClassScheduleRequest, HisDataResponse2<HisShemaInfo[]>>("2003", request);
            var data = result.json.data?.Select(hisShemaInfoParser)?.ToArray();

            return (result.flag, result.msg, data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, IEnumerable<string> data) ClassPoint(ClassPointRequest request)
        {
            var result = Invoke<ClassPointRequest, HisShemaPointResponse>("2004", request);
            var data = result.json.timeinfo?.Split(",");

            return (result.flag, result.msg, data);
        }

        private Func<HisSaveBookingInfo, SubscribeSubmitData> hisSaveBookingInfoParser = (h) => new SubscribeSubmitData
        {
            clinicNo = h.clinicNo,
            seeNo = h.seeNo,
            subscribeId = h.bookingNo
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, SubscribeSubmitData data) SubscribeSubmit(SubscribeSubmitRequest request)
        {
            var result = Invoke<SubscribeSubmitRequest, HisDataResponse<HisSaveBookingInfo>>("2008", request);
            var data = hisSaveBookingInfoParser(result.json.data);

            return (result.flag, result.msg, data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, bool data) SubscribeCancel(SubscribeCancelRequest request)
        {
            var result = Invoke<SubscribeCancelRequest, HisResponseBase>("2007", request);
            return (result.flag, result.msg, result.flag);
        }

        private Func<HisBookingInfoResponse, SubscribeQueryData> hisBookingInfoParser = (h) => new SubscribeQueryData
        {
            deptName = h.deptName,
            state = h.state
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, SubscribeQueryData data) SubscribeQuery(SubscribeQueryRequest request)
        {
            var result = Invoke<SubscribeQueryRequest, HisBookingInfoResponse>("2005", request);
            var data = hisBookingInfoParser(result.json);

            return (result.flag, result.msg, data);
        }

        private Func<HisRegisterInfo, RegisterSubmitData> hisRegisterInfoParser = (h) => new RegisterSubmitData
        {
            //clinicNo = h.clinicNo,
            seeNo = h.seeNo,
            tradeNo = h.tradeNo,
            address = h.address,
            deptName = h.deptName,
            registerHisId = h.hisRegisterId,
            registerId = h.registerId,
            vancy = h.vancy
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, RegisterSubmitData data) RegisterSubmit(RegisterSubmitRequest request)
        {
            var result = Invoke<RegisterSubmitRequest, HisDataResponse2<HisRegisterInfo>>("3004", request);
            var data = hisRegisterInfoParser(result.json.data);

            return (result.flag, result.msg, data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, bool data) RegisterCancel(RegisterCancelRequest request)
        {
            var result = Invoke<RegisterCancelRequest, HisResponseBase>("3005", request);

            return (result.flag, result.msg, result.flag);
        }

        private Func<HisFeeRegInfo, FeeRecipeQueryData> hisFeeRegInfoParser = (h) => new FeeRecipeQueryData
        {
            doctDeptName = h.DocDept_Name,
            doctName = h.Doc_Name,
            drugFlag = h.Drug_Flag,
            execDeptCode = h.Exec_DeptCode,
            execDeptName = h.Exec_DeptName,
            feeCode = h.Fee_Code,
            invoiceNo = h.InvoiceNo,
            itemCode = h.Item_Code,
            itemName = h.Item_Name,
            moDate = h.Mo_Date,
            payFlag = h.Pay_Flag,
            qty = h.Qty,
            recipeId = h.Recipe_Key,
            recipeNo = h.Recipe_No,
            seqNo = h.SeqNo,
            totCost = h.Tot_Cost,
            transType = h.Trans_Type,
            unit = h.UNIT,
            unitPrice = h.Unit_Price,
            ybItemInfo = h.Yb_Item_Info
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, IEnumerable<FeeRecipeQueryData> data) FeeRegisterQuery(FeeRecipeQueryRequest request)
        {
            var result = Invoke<FeeRecipeQueryRequest, HisDataResponse<HisFeeRegInfo[]>>("3006", request);
            var data = result.json.data?.Select(hisFeeRegInfoParser)?.ToArray();

            return (result.flag, result.msg, data);
        }

        private Func<HisReportInfo, ReportQueryData> hisReportInfoParser = (h) => new ReportQueryData
        {
            checkType = h.checkType,
            itemName = h.itemName,
            realName = h.realName,
            reportId = h.queryId,
            status = h.status
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, IEnumerable<ReportQueryData> data) ReportQuery(ReportQueryRequest request)
        {
            var result = Invoke<ReportQueryRequest, HisDataResponse<HisReportInfo[]>>("5001", request);
            var data = result.json.data?.Select(hisReportInfoParser)?.ToArray();

            return (result.flag, result.msg, data);
        }

        private (bool flag, string msg, TJsonResult json) Invoke<TRequest, TJsonResult>(string code, TRequest request)
            where TJsonResult : HisResponseBase
        {
            var data = new HospRequest<TRequest>(code, request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<TJsonResult>(hisResultSource.FormatResult);

            return (verifyHisResult(hisResult.result), hisResult.message, hisResult);
        }

        private Func<string, bool> verifyHisResult = (result) =>
        {
            return string.IsNullOrEmpty(result) ? false : result.ToLower() == "success";
        };
    }
}
