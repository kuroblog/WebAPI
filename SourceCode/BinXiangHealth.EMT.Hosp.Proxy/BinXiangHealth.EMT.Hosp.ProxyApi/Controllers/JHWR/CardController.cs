using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class CardController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.Create<IProxyService>();

        [Route("api/v1/card/query")]
        public ApiResult<CardQueryResponse> CardQuery(CardQueryRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp1002Request, HModels.Hosp1002Response, CardQueryRequest, CardQueryResponse>(
                    request,
                    p => new HModels.Hosp1002Request
                    {
                        idCard = p.idCard,
                        mCardNo = p.cardNo,
                        mType = p.cardType,
                        queryType = p.queryType,
                        realName = p.name
                    },
                    p => new CardQueryResponse
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
                    }));
        }
    }
}
