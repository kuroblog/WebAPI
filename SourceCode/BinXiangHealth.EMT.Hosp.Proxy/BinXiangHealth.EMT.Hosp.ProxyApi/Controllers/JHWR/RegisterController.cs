using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using System.Linq;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class RegisterController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.Create<IProxyService>();

        [Route("api/v1/register/query")]
        public ApiArrayResult<RegisterQueryResponse> PreRegisterQuery(RegisterQueryRequest request)
        {
            return this.DoApiArrayResult(
                proxyService.DoTrans<HModels.HospRegisterQueryRequest, HModels.HospRegisterQueryResponse, RegisterQueryRequest, RegisterQueryResponse[]>(
                    request,
                    p => new HModels.HospRegisterQueryRequest
                    {
                        beginDate = p.begDate,
                        cardNo = p.cardNo,
                        endDate = p.endDate
                    },
                    p => p.data?.Select(a => new RegisterQueryResponse
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
                    })?.ToArray()));
        }

        [Route("api/v1/register/do")]
        public ApiResult<RegisterDoResponse> RegisterDo(RegisterDoRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp3004Request, HModels.Hosp3004Response, RegisterDoRequest, RegisterDoResponse>(
                    request,
                    p => new HModels.Hosp3004Request
                    {
                        clinicFee = p.cost,
                        departmentCode = p.deptCode,
                        departmentName = p.deptName,
                        doctorCode = p.doctCode,
                        doctorName = p.doctName,
                        isFee = p.isFee,
                        operCode = p.operCode,
                        pactCode = p.pactCode,
                        patientCard = p.cardNo,
                        realName = p.name,
                        registrationDate = p.regDate,
                        registrationLevel = p.regCode,
                        registrationNoonCode = p.regNoonCode,
                        registrationTime = p.regTime,
                        registrationType = p.regType,
                        shemaId = p.id,
                        termId = p.termId
                    },
                    p => new RegisterDoResponse
                    {
                        clinicNo = p.data?.clinicNo,
                        seeNo = p.data?.seeNo
                    }));
        }

        [Route("api/v1/register/callback")]
        public ApiResult<RegisterCallbackResponse> RegisterCallback(RegisterCallbackRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.HospRegCallbackRequest, HModels.HospRegCallbackResponse, RegisterCallbackRequest, RegisterCallbackResponse>(
                    request,
                    p => new HModels.HospRegCallbackRequest
                    {
                        clinicNo = p.clinicNo,
                        feeSource = p.source,
                        isFee = p.isFee,
                        payFee = p.cost,
                        siInfo = p.siInfo,
                        thirdOrderNo = p.thirdNo,
                        tradeNo = p.tradeNo
                    },
                    p => new RegisterCallbackResponse
                    {
                        state = p.data == null ? 0 : p.data.state
                    }));
        }

        [Route("api/v1/register/cancel")]
        public ApiResult<RegisterCancelResponse> RegisterCancel(RegisterCancelRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp3005Request, HModels.Hosp3005Response, RegisterCancelRequest, RegisterCancelResponse>(
                    request,
                    p => new HModels.Hosp3005Request
                    {
                        clinicNo = p.clinicNo,
                        operCode = p.operCode
                    },
                    p => new RegisterCancelResponse
                    {
                        state = p.data == null ? 0 : p.data.state
                    }));
        }
    }
}
