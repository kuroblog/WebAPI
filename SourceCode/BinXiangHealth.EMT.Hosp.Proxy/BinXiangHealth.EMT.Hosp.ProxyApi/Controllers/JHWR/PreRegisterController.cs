using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using System.Linq;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class PreRegisterController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/pre/query")]
        public ApiArrayResult<PreRegisterQueryResponse> PreRegisterQuery(PreRegisterQueryRequest request)
        {
            var hisRequest = new HModels.HospPreRegisterQueryRequest
            {
                beginDate = request.begDate,
                cardNo = request.cardNo,
                endDate = request.endDate
            };

            var result =
                proxyService.Do<HModels.HospPreRegisterQueryRequest, HModels.HospPreRegisterQueryResponse, PreRegisterQueryResponse[]>(
                    hisRequest,
                    (p) => p?.data?.Select(a => new PreRegisterQueryResponse
                    {
                        cardNo = a.idCardNo,
                        clinicNo = a.clinicNo,
                        cost = a.total,
                        deptName = a.deptName,
                        doctName = a.doctName,
                        doctTitle = a.doctTitle,
                        name = a.idCardName,
                        preNo = a.bookingNo,
                        regDate = a.date,
                        regType = a.regType,
                        seeNo = a.seeNo,
                        state = a.state,
                        visistDate = a.visistDate,
                        visitingTime = a.visitingTime
                    })?.ToArray());

            return new ApiArrayResult<PreRegisterQueryResponse>
            {
                Success = result.state == 0,
                ResultData = result.data?.ToList(),
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }

        [Route("api/v1/pre/do")]
        public ApiResult<PreRegisterDoResponse> PreRegisterDo(PreRegisterDoRequest request)
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

            var result = proxyService.Do<HModels.Hosp2011Request, HModels.Hosp2011Response, PreRegisterDoResponse>(
                hisRequest,
                (p) => new PreRegisterDoResponse
                {
                    clinicNo = p.data?.clinicNo
                });

            return new ApiResult<PreRegisterDoResponse>
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
        public ApiResult<PreRegisterCancelResponse> PreRegisterCancel(PreRegisterCancelRequest request)
        {
            var hisRequest = new HModels.Hosp2007Request
            {
                bookingNo = request.preNo,
                operCode = request.operCode
            };

            var result = proxyService.Do<HModels.Hosp2007Request, HModels.Hosp2007Response, PreRegisterCancelResponse>(
                hisRequest,
                (p) => new PreRegisterCancelResponse
                {
                    state = p.data == null ? 0 : p.data.state
                });

            return new ApiResult<PreRegisterCancelResponse>
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
