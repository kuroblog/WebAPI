using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using Flysh.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using HModels = Flysh.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace Flysh.Hosp.ProxyApi.Controllers.JHWR
{
    public class PreRegisterController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/pre/cancel")]
        public ApiResult<PreDoResponse> PreDo(PreDoRequest request)
        {
            var hisRequest = new HModels.Hosp2011Request
            {
                bookingNo = request.preNo,
                clinicFee = request.preCost,
                feeSource = request.source,
                operCode = request.operCode,
                pactCode = request.pactCode,
                tradeNo = request.tradeNo
            };

            var result = proxyService.Do<HModels.Hosp2011Request, HModels.Hosp2011Response, PreDoResponse>(
                hisRequest,
                (p) => new PreDoResponse
                {
                    clinicNo = p.data?.clinicNo
                });

            return new ApiResult<PreDoResponse>
            {
                Success = result.state == 0,
                ResultData = result.data,
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }

        [Route("api/v1/pre/cancel")]
        public ApiResult<PreCancelResponse> PreCancel(PreCancelRequest request)
        {
            var hisRequest = new HModels.Hosp2007Request
            {
                bookingNo = request.preNo,
                operCode = request.operCode
            };

            var result = proxyService.Do<HModels.Hosp2007Request, HModels.Hosp2007Response, PreCancelResponse>(
                hisRequest,
                (p) => new PreCancelResponse
                {
                    state = p.data == null ? 0 : p.data.state
                });

            return new ApiResult<PreCancelResponse>
            {
                Success = result.state == 0,
                ResultData = result.data,
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }

        [Route("api/v1/pre/register")]
        public ApiResult<PreRegisterResponse> PreRegister(PreRegisterRequest request)
        {
            var hisRequest = new HModels.Hosp2008Request
            {
                bookSource = request.preSource,
                cardNo = request.cardNo,
                clinicFee = request.preCost,
                deptCode = request.deptCode,
                isExpert = request.preType,
                isFee = request.isFee,
                preTime = request.preTime,
                realName = request.name,
                shemaId = request.id
            };

            var result = proxyService.Do<HModels.Hosp2008Request, HModels.Hosp2008Response, PreRegisterResponse>(
                hisRequest,
                (p) => new PreRegisterResponse
                {
                    clinicNo = p.data?.clinicNo,
                    preNo = p.data?.bookingNo,
                    seeNo = p.data?.seeNo
                });

            return new ApiResult<PreRegisterResponse>
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
