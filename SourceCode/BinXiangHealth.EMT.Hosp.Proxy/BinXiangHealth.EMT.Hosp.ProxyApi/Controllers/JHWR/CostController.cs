using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class CostController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.Create<IProxyService>();

        [Route("api/v1/cost/pre")]
        public ApiResult<CostPreResponse> CostPre(CostPreRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp4003Request, HModels.Hosp4003Response, CostPreRequest, CostPreResponse>(
                request,
                p => new HModels.Hosp4003Request
                {
                    clinicNo = p.clinicNo,
                    operCode = p.operCode,
                    realName = p.name,
                    recipe_Key = p.recipeKey
                },
                p => new CostPreResponse
                {
                    ownCost = p.data?.ownCost,
                    payCost = p.data?.payCost,
                    pubCost = p.data?.pubCost,
                    totCost = p.data?.totCost
                }));
        }
    }
}
