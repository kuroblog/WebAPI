
namespace Flysh.HospInterface.ProxyApi.Services
{
    using Flysh.HospInterface.ProxyApi.His;
    using Flysh.HospInterface.ProxyApi.His.Dto;
    using Flysh.HospInterface.ProxyApi.Models;
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IProxyService
    {
        Task<string> HisInterfaceTest<TData>(HisDoTransRequest<TData> request);

        ClassesScheduleResponse[] ClassesSchedule(ClassesScheduleRequest request);
    }

    public class ProxyService : IProxyService
    {
        private readonly IHisProxyInterface service;

        public ProxyService(HisProxyFactory proxyFactory)
        {
            service = proxyFactory.Instance;
        }

        public async Task<string> HisInterfaceTest<TData>(HisDoTransRequest<TData> request)
        {
            var hisResult = await service.DoTransAsync(request);

            return await Task.FromResult(hisResult.FormatResult);
        }

        private Func<HisShemaInfo, ClassesScheduleResponse> hisShemaInfoParser = (his) => new ClassesScheduleResponse
        {
            adress = his.ADRESS,
            beginTime = his.BEGIN_TIME,
            deptCode = his.DEPT_CODE,
            deptName = his.DEPT_NAME,
            doctCode = his.DOCT_CODE,
            doctName = his.DOCT_NAME,
            endTime = his.END_TIME,
            id = his.ID,
            nooncode = his.NOONCODE,
            regLevl = his.REGLEVL_NAME,
            regLmt = his.REG_LMT,
            regReged = his.REG_REGED,
            regType = his.REGISTRATION_TYPE,
            seeDate = his.SEE_DATE,
            totCost = his.TOT_COST,
            week = his.WEEK
        };

        public ClassesScheduleResponse[] ClassesSchedule(ClassesScheduleRequest request)
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
    }
}
