
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
        (bool result, string message, IEnumerable<ClassScheduleItem> data) ClassSchedule(ClassScheduleRequest request);

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
        (bool result, string message, IEnumerable<FeeRegisterQueryData> data) FeeRegisterQuery(FeeRegisterQueryRequest request);

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

        private Func<HisShemaInfo, ClassScheduleItem> hisShemaInfoParser = (h) => new ClassScheduleItem
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
        public (bool result, string message, IEnumerable<ClassScheduleItem> data) ClassSchedule(ClassScheduleRequest request)
        {
            var data = new HospRequest<ClassScheduleRequest>("2003", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisDataResponse2<HisShemaInfo[]>>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisResult.data?.Select(hisShemaInfoParser)?.ToArray();

            return (rValue, mValue, dValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, IEnumerable<string> data) ClassPoint(ClassPointRequest request)
        {
            var data = new HospRequest<ClassPointRequest>("2004", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisShemaPointResponse>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisResult.timeinfo?.Split(",");

            return (rValue, mValue, dValue);
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
            var data = new HospRequest<SubscribeSubmitRequest>("2008", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisDataResponse<HisSaveBookingInfo>>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisSaveBookingInfoParser(hisResult.data);

            return (rValue, mValue, dValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, bool data) SubscribeCancel(SubscribeCancelRequest request)
        {
            var data = new HospRequest<SubscribeCancelRequest>("2007", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisResponseBase>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = rValue;

            return (rValue, mValue, dValue);
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
            var data = new HospRequest<SubscribeQueryRequest>("2005", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisBookingInfoResponse>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisBookingInfoParser(hisResult);

            return (rValue, mValue, dValue);
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
            var data = new HospRequest<RegisterSubmitRequest>("3004", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisDataResponse2<HisRegisterInfo>>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisRegisterInfoParser(hisResult.data);

            return (rValue, mValue, dValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, bool data) RegisterCancel(RegisterCancelRequest request)
        {
            var data = new HospRequest<RegisterCancelRequest>("3005", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisResponseBase>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = rValue;

            return (rValue, mValue, dValue);
        }

        private Func<HisFeeRegInfo, FeeRegisterQueryData> hisFeeRegInfoParser = (h) => new FeeRegisterQueryData
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
        public (bool result, string message, IEnumerable<FeeRegisterQueryData> data) FeeRegisterQuery(FeeRegisterQueryRequest request)
        {
            var data = new HospRequest<FeeRegisterQueryRequest>("3006", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisDataResponse<HisFeeRegInfo[]>>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisResult.data?.Select(hisFeeRegInfoParser)?.ToArray();

            return (rValue, mValue, dValue);
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
            var data = new HospRequest<ReportQueryRequest>("5001", request);

            var hisResultSource = service.Invoke(data);
            var hisResult = JsonConvert.DeserializeObject<HisDataResponse<HisReportInfo[]>>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisResult.data?.Select(hisReportInfoParser)?.ToArray();

            return (rValue, mValue, dValue);
        }

        private Func<string, bool> verifyHisResult = (result) =>
        {
            return string.IsNullOrEmpty(result) ? false : result.ToLower() == "success";
        };
    }
}
