using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class CardController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/card/query")]
        public ApiResult<CardQueryResponse> CardQuery(CardQueryRequest request)
        {
            var hisRequest = new HModels.Hosp1002Request
            {
                idCard = request.idCard,
                mCardNo = request.cardNo,
                mType = request.cardType,
                queryType = request.queryType,
                realName = request.name
            };

            var result = proxyService.Do<HModels.Hosp1002Request, HModels.Hosp1002Response, CardQueryResponse>(
                hisRequest,
                (p) => new CardQueryResponse
                {
                    birthday = p.data?.birthday,
                    cardNo = p.data?.cardNo,
                    linkmanAdd = p.data?.linkman_add,
                    linkmanName = p.data?.linkman_name,
                    linkmanTel = p.data?.linkman_tel,
                    name = p.data?.name,
                    pactCode = p.data?.pactCode,
                    sex = p.data?.sex,
                    vacancy = p.data?.vacancy
                });

            return new ApiResult<CardQueryResponse>
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
