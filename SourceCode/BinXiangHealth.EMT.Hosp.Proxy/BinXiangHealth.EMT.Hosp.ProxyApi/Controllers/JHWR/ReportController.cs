using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using System.Linq;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class ReportController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.Create<IProxyService>();

        [Route("api/v1/report/detail")]
        public ApiArrayResult<ReportDetailResponse> ReportDetail(ReportDetailRequest request)
        {
            return this.DoApiArrayResult(
                proxyService.DoTrans<HModels.HospReportDetailRequest, HModels.HospReportDetailResponse, ReportDetailRequest, ReportDetailResponse[]>(
                    request,
                    p => new HModels.HospReportDetailRequest
                    {
                        checkType = p.type,
                        queryId = p.id
                    },
                    p => p.data?.Select(a => new ReportDetailResponse
                    {
                        actual = a.realResult,
                        conclusion = a.conclusion,
                        date = a.checkDate,
                        itemName = a.itemName,
                        name = a.realName,
                        reference = a.referprint,
                        sample = a.sample,
                        sex = a.sex,
                        type = a.type
                    })?.ToArray()));
        }
    }
}
