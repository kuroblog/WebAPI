
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
        Task<string> HisInterfaceTest<TData>(HisDoTransRequest<TData> request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IEnumerable<ClassesScheduleData> ClassesSchedule(ClassesScheduleRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IEnumerable<string> ClassesPoint(ClassesPointRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ClassesSubscribeData ClassesSubscribe(ClassesSubscribeRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool ClassesSubscribeCancel(ClassesSubscribeCancelRequest request);
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
        public async Task<string> HisInterfaceTest<TData>(HisDoTransRequest<TData> request)
        {
            var hisResult = await service.DoTransAsync(request);

            return await Task.FromResult(hisResult.FormatResult);
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
        public IEnumerable<ClassesScheduleData> ClassesSchedule(ClassesScheduleRequest request)
        {
            var data = new HisDoTransRequest<ClassesScheduleRequest>
            {
                code = "2003",
                data = request
            };

            var hisResult = service.DoTrans(data);

            var hisFormatResult = JsonConvert.DeserializeObject<HisDoTransResponse<HisShemaInfo[]>>(hisResult.FormatResult);

            return hisFormatResult?.data?.Select(hisShemaInfoParser)?.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IEnumerable<string> ClassesPoint(ClassesPointRequest request)
        {
            var data = new HisDoTransRequest<ClassesPointRequest>
            {
                code = "2004",
                data = request
            };

            var hisResult = service.DoTrans(data);

            var hisFormatResult = JsonConvert.DeserializeObject<HisShemaPointInfo>(hisResult.FormatResult);

            return hisFormatResult?.timeinfo?.Split(",");
        }

        private Func<HisSaveBookingInfo, ClassesSubscribeData> hisSaveBookingInfoParser = (his) => new ClassesSubscribeData
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
        public ClassesSubscribeData ClassesSubscribe(ClassesSubscribeRequest request)
        {
            var data = new HisDoTransRequest<ClassesSubscribeRequest>
            {
                code = "2008",
                data = request
            };

            var hisResult = service.DoTrans(data);

            var hisFormatResult = JsonConvert.DeserializeObject<BaseHisDataResponse<HisSaveBookingInfo>>(hisResult.FormatResult);

            return hisSaveBookingInfoParser(hisFormatResult.data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public bool ClassesSubscribeCancel(ClassesSubscribeCancelRequest request)
        {
            var data = new HisDoTransRequest<ClassesSubscribeCancelRequest>
            {
                code = "2007",
                data = request
            };

            var hisResult = service.DoTrans(data);

            var hisFormatResult = JsonConvert.DeserializeObject<BaseHisResponse>(hisResult.FormatResult);

            return hisFormatResult.result.ToLower() == "success";
        }
    }
}
