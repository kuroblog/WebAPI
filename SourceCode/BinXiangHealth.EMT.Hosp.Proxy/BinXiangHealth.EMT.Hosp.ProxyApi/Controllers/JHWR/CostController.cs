using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class CostController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/cost/pre")]
        public ApiResult<CostPreResponse> CostPre(CostPreRequest request)
        {
            var hisRequest = new HModels.Hosp4003Request
            {
                clinicNo = request.clinicNo,
                operCode = request.operCode,
                realName = request.name,
                recipe_Key = request.recipeKey
            };

            var result = proxyService.Do<HModels.Hosp4003Request, HModels.Hosp4003Response, CostPreResponse>(
                hisRequest,
                (p) => new CostPreResponse
                {
                    ownCost = p.data?.ownCost,
                    payCost = p.data?.payCost,
                    pubCost = p.data?.pubCost,
                    totCost = p.data?.totCost
                });

            return new ApiResult<CostPreResponse>
            {
                Success = result.state == 0,
                ResultData = result.data,
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }
    }
}
