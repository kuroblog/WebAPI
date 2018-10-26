
namespace Flysh.HospInterface.ProxyApi.Services
{
    using Flysh.HospInterface.ProxyApi.His;
    using Flysh.HospInterface.ProxyApi.His.Dto;
    using Flysh.HospInterface.ProxyApi.Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
        (bool result, string message, string data) HisTest<TData>(HisDoTransRequest<TData> request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, IEnumerable<ClassesScheduleData> data) ClassesSchedule(ClassesScheduleRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        (bool result, string message, IEnumerable<string> data) ClassesPoint(ClassesPointRequest request);

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
    }

    /// <summary>
    /// 
    /// </summary>
    public class ProxyService : IProxyService
    {
        private readonly IHisProxyInterface service;

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
        public (bool result, string message, string data) HisTest<TData>(HisDoTransRequest<TData> request)
        {
            var hisResultSource = service.DoTrans(request);

            var rValue = true;
            var mValue = "";
            var dValue = hisResultSource.HisResult;

            return (rValue, mValue, dValue);
        }

        private Func<HisShemaInfo, ClassesScheduleData> hisShemaInfoParser = (his) => new ClassesScheduleData
        {
            adress = his.ADRESS,
            beginTime = his.BEGIN_TIME,
            deptCode = his.DEPT_CODE,
            deptName = his.DEPT_NAME,
            doctCode = his.DOCT_CODE,
            doctName = his.DOCT_NAME,
            endTime = his.END_TIME,
            classId = his.ID,
            nooncode = his.NOONCODE,
            regLevl = his.REGLEVL_NAME,
            regLmt = his.REG_LMT,
            regReged = his.REG_REGED,
            regType = his.REGISTRATION_TYPE,
            seeDate = his.SEE_DATE,
            totCost = his.TOT_COST,
            week = his.WEEK
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, IEnumerable<ClassesScheduleData> data) ClassesSchedule(ClassesScheduleRequest request)
        {
            var data = new HisDoTransRequest<ClassesScheduleRequest>("2003", request);

            var hisResultSource = service.DoTrans(data);
            var hisResult = JsonConvert.DeserializeObject<HisDoTransResponse<HisShemaInfo[]>>(hisResultSource.FormatResult);

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
        public (bool result, string message, IEnumerable<string> data) ClassesPoint(ClassesPointRequest request)
        {
            var data = new HisDoTransRequest<ClassesPointRequest>("2004", request);

            var hisResultSource = service.DoTrans(data);
            var hisResult = JsonConvert.DeserializeObject<HisShemaPointResponse>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisResult.timeinfo?.Split(",");

            return (rValue, mValue, dValue);
        }

        private Func<HisSaveBookingInfo, SubscribeSubmitData> hisSaveBookingInfoParser = (his) => new SubscribeSubmitData
        {
            clinicNo = his.clinicNo,
            seeNo = his.seeNo,
            subscribeId = his.bookingNo
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, SubscribeSubmitData data) SubscribeSubmit(SubscribeSubmitRequest request)
        {
            var data = new HisDoTransRequest<SubscribeSubmitRequest>("2008", request);

            var hisResultSource = service.DoTrans(data);
            var hisResult = JsonConvert.DeserializeObject<BaseHisDataResponse<HisSaveBookingInfo>>(hisResultSource.FormatResult);

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
            var data = new HisDoTransRequest<SubscribeCancelRequest>("2007", request);

            var hisResultSource = service.DoTrans(data);
            var hisResult = JsonConvert.DeserializeObject<BaseHisResponse>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = rValue;

            return (rValue, mValue, dValue);
        }

        private Func<HisBookingInfoResponse, SubscribeQueryData> hisBookingInfoParser = (his) => new SubscribeQueryData
        {
            deptName = his.deptName,
            state = his.state
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, SubscribeQueryData data) SubscribeQuery(SubscribeQueryRequest request)
        {
            var data = new HisDoTransRequest<SubscribeQueryRequest>("2005", request);

            var hisResultSource = service.DoTrans(data);
            var hisResult = JsonConvert.DeserializeObject<HisBookingInfoResponse>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = hisBookingInfoParser(hisResult);

            return (rValue, mValue, dValue);
        }

        private Func<HisRegisterInfo, RegisterSubmitData> hisRegisterInfoParser = (his) => new RegisterSubmitData
        {
            clinicNo = his.clinicNo,
            seeNo = his.seeNo,
            tradeNo = his.tradeNo,
            address = his.address,
            deptName = his.deptName,
            registerHisId = his.registerHisId,
            registerId = his.registerId,
            vancy = his.vancy
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public (bool result, string message, RegisterSubmitData data) RegisterSubmit(RegisterSubmitRequest request)
        {
            var data = new HisDoTransRequest<RegisterSubmitRequest>("3004", request);

            var hisResultSource = service.DoTrans(data);
            var hisResult = JsonConvert.DeserializeObject<HisDoTransResponse<HisRegisterInfo>>(hisResultSource.FormatResult);

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
            var data = new HisDoTransRequest<RegisterCancelRequest>("3005", request);

            var hisResultSource = service.DoTrans(data);
            var hisResult = JsonConvert.DeserializeObject<BaseHisResponse>(hisResultSource.FormatResult);

            var rValue = verifyHisResult(hisResult.result);
            var mValue = hisResult.message;
            var dValue = rValue;

            return (rValue, mValue, rValue);
        }

        private Func<string, bool> verifyHisResult = (result) =>
        {
            return string.IsNullOrEmpty(result) ? false : result.ToLower() == "success";
        };
    }
}
