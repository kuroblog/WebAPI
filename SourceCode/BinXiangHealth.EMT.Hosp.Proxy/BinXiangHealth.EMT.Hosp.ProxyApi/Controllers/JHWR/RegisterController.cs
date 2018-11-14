using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using Flysh.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using System.Linq;
using HModels = Flysh.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace Flysh.Hosp.ProxyApi.Controllers.JHWR
{
    public class RegisterController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/register/query")]
        public ApiArrayResult<RegisterQueryResponse> PreRegisterQuery(RegisterQueryRequest request)
        {
            var hisRequest = new HModels.HospRegisterQueryRequest
            {
                beginDate = request.begDate,
                cardNo = request.cardNo,
                endDate = request.endDate
            };

            var result =
                proxyService.Do<HModels.HospRegisterQueryRequest, HModels.HospRegisterQueryResponse, RegisterQueryResponse[]>(
                    hisRequest,
                    (p) => p?.data?.Select(a => new RegisterQueryResponse
                    {
                        cardNo = a.idCardNo,
                        clinicNo = a.clinicNo,
                        cost = a.total,
                        deptName = a.deptName,
                        doctName = a.doctName,
                        doctTitle = a.doctTitle,
                        name = a.idCardName,
                        regDate = a.date,
                        regType = a.regType,
                        seeNo = a.seeNo,
                        state = a.state,
                        visistDate = a.visistDate,
                        visitingTime = a.visitingTime
                    })?.ToArray());

            return new ApiArrayResult<RegisterQueryResponse>
            {
                Success = result.state == 0,
                ResultData = result.data?.ToList(),
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }

        [Route("api/v1/register/do")]
        public ApiResult<RegisterDoResponse> RegisterDo(RegisterDoRequest request)
        {
            var hisRequest = new HModels.Hosp3004Request
            {
                clinicFee = request.cost,
                departmentCode = request.deptCode,
                departmentName = request.deptName,
                doctorCode = request.doctCode,
                doctorName = request.doctName,
                isFee = request.isFee,
                operCode = request.operCode,
                pactCode = request.pactCode,
                patientCard = request.cardNo,
                realName = request.name,
                registrationDate = request.regDate,
                registrationLevel = request.regCode,
                registrationNoonCode = request.regNoonCode,
                registrationTime = request.regTime,
                registrationType = request.regType,
                shemaId = request.id,
                termId = request.termId
            };

            var result = proxyService.Do<HModels.Hosp3004Request, HModels.Hosp3004Response, RegisterDoResponse>(
                hisRequest,
                (p) => new RegisterDoResponse
                {
                    clinicNo = p.data?.clinicNo,
                    seeNo = p.data?.seeNo
                });

            return new ApiResult<RegisterDoResponse>
            {
                Success = result.state == 0,
                ResultData = result.data,
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }

        [Route("api/v1/register/callback")]
        public ApiResult<RegisterCallbackResponse> RegisterCallback(RegisterCallbackRequest request)
        {
            var hisRequest = new HModels.HospRegCallbackRequest
            {
                clinicNo = request.clinicNo,
                feeSource = request.source,
                isFee = request.isFee,
                payFee = request.cost,
                siInfo = request.siInfo,
                thirdOrderNo = request.thirdNo,
                tradeNo = request.tradeNo
            };

            var result = proxyService.Do<HModels.HospRegCallbackRequest, HModels.HospRegCallbackResponse, RegisterCallbackResponse>(
                hisRequest,
                (p) => new RegisterCallbackResponse
                {
                    state = p.data == null ? 0 : p.data.state
                });

            return new ApiResult<RegisterCallbackResponse>
            {
                Success = result.state == 0,
                ResultData = result.data,
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }

        [Route("api/v1/register/cancel")]
        public ApiResult<RegisterCancelResponse> RegisterCancel(RegisterCancelRequest request)
        {
            var hisRequest = new HModels.Hosp3005Request
            {
                clinicNo = request.clinicNo,
                operCode = request.operCode
            };

            var result = proxyService.Do<HModels.Hosp3005Request, HModels.Hosp3005Response, RegisterCancelResponse>(
                hisRequest,
                (p) => new RegisterCancelResponse
                {
                    state = p.data == null ? 0 : p.data.state
                });

            return new ApiResult<RegisterCancelResponse>
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
