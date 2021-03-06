using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using System.Linq;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class ScheduleController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.Create<IProxyService>();

        [Route("api/v1/schedule/query")]
        public ApiArrayResult<ScheduleQueryResponse> ScheduleQuery(ScheduleQueryRequest request)
        {
            return this.DoApiArrayResult(
                proxyService.DoTrans<HModels.Hosp2003Request, HModels.Hosp2003Response, ScheduleQueryRequest, ScheduleQueryResponse[]>(
                    request,
                    p => new HModels.Hosp2003Request
                    {
                        beginDate = p.begDate,
                        deptCode = p.deptCode,
                        endDate = p.endDate,
                        isPre = p.isPre
                    },
                    p => p.data?.Select(a => new ScheduleQueryResponse
                    {
                        address = a.ADRESS,
                        begTime = a.BEGIN_TIME,
                        costCode = a.ITEMCODE,
                        date = a.SEE_DATE,
                        deptCode = a.DEPT_CODE,
                        deptDesc = "",
                        deptName = a.DEPT_NAME,
                        doctCode = a.DOCT_CODE,
                        doctDesc = "",
                        doctName = a.DOCT_NAME,
                        endTime = a.END_TIME,
                        id = a.ID,
                        limit = a.BOOKING_LMT,
                        noonCode = a.NOONCODE,
                        noonName = a.NOONNAME,
                        regCode = a.REGLEVL_CODE,
                        regCost = a.TOT_COST,
                        registered = a.TEL_REGED,
                        regName = a.REGLEVL_NAME,
                        regType = a.REGISTRATION_TYPE,
                        sortId = a.SORTID,
                        week = a.WEEK
                    })?.ToArray()));
        }
    }
}
