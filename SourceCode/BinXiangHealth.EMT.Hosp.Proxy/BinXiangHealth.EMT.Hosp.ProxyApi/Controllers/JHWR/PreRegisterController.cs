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
        private readonly IProxyService proxyService = IocHelper.Create<IProxyService>();

        [Route("api/v1/pre/query")]
        public ApiArrayResult<PreRegisterQueryResponse> PreRegisterQuery(PreRegisterQueryRequest request)
        {
            return this.DoApiArrayResult(
                proxyService.DoTrans<HModels.HospPreRegisterQueryRequest, HModels.HospPreRegisterQueryResponse, PreRegisterQueryRequest, PreRegisterQueryResponse[]>(
                    request,
                    p => new HModels.HospPreRegisterQueryRequest
                    {
                        beginDate = p.begDate,
                        cardNo = p.cardNo,
                        endDate = p.endDate
                    },
                    p => p.data?.Select(a => new PreRegisterQueryResponse
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
                    })?.ToArray()));
        }

        [Route("api/v1/pre/do")]
        public ApiResult<PreRegisterDoResponse> PreRegisterDo(PreRegisterDoRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp2011Request, HModels.Hosp2011Response, PreRegisterDoRequest, PreRegisterDoResponse>(
                    request,
                    p => new HModels.Hosp2011Request
                    {
                        bookingNo = p.preNo,
                        clinicFee = p.preCost,
                        feeSource = p.source,
                        operCode = p.operCode,
                        pactCode = p.pactCode,
                        tradeNo = p.tradeNo
                    },
                    p => new PreRegisterDoResponse
                    {
                        clinicNo = p.data?.clinicNo
                    }));
        }

        [Route("api/v1/pre/cancel")]
        public ApiResult<PreRegisterCancelResponse> PreRegisterCancel(PreRegisterCancelRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp2007Request, HModels.Hosp2007Response, PreRegisterCancelRequest, PreRegisterCancelResponse>(
                    request,
                    p => new HModels.Hosp2007Request
                    {
                        bookingNo = p.preNo,
                        operCode = p.operCode
                    },
                    p => new PreRegisterCancelResponse
                    {
                        state = p.data == null ? 0 : p.data.state
                    }));
        }

        [Route("api/v1/pre/register")]
        public ApiResult<PreRegisterResponse> PreRegister(PreRegisterRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp2008Request, HModels.Hosp2008Response, PreRegisterRequest, PreRegisterResponse>(
                    request,
                    p => new HModels.Hosp2008Request
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
                    },
                    p => new PreRegisterResponse
                    {
                        clinicNo = p.data?.clinicNo,
                        preNo = p.data?.bookingNo,
                        seeNo = p.data?.seeNo
                    }));
        }
    }
}
