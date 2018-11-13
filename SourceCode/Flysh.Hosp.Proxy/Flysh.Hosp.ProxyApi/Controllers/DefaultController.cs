using Flysh.Hosp.ProxyApi.Models;
using System;
using System.Linq;
using DTO = Flysh.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace Flysh.Hosp.ProxyApi.Controllers
{
    public class DefaultController : Agebull.ZeroNet.ZeroApi.ApiController
    {
        private readonly ITestService tService = Agebull.Common.Ioc.IocHelper.CreateScope<ITestService>();

        [Agebull.ZeroNet.ZeroApi.Route("api/default/hello")]
        public Gboxt.Common.DataModel.ApiResult Hello()
        {
            return new Gboxt.Common.DataModel.ApiResult<string>
            {
                ResultData = tService.Hello
            };
        }

        private readonly IProxyService proxyService = Agebull.Common.Ioc.IocHelper.CreateScope<IProxyService>();

        [Agebull.ZeroNet.ZeroApi.Route("api/default/test")]
        public Gboxt.Common.DataModel.ApiArrayResult<ScheduleQueryResponseModel> Test(ScheduleQueryRequestModel request)
        {
            var hisRequest = new DTO.Hosp2003Request
            {
                beginDate = request.begDate,
                deptCode = request.deptCode,
                endDate = request.endDate,
                isPre = request.isPre
            };

            var result = proxyService.Do<DTO.Hosp2003Request, DTO.Hosp2003Response, ScheduleQueryResponseModel[]>(hisRequest, (p) => p?.data?.Select(a => new ScheduleQueryResponseModel
            {
                address = a.ADRESS,
                begTime = a.BEGIN_TIME,
                costCode = a.ITEMCODE,
                date = a.SEE_DATE,
                deptCode = a.DEPT_CODE,
                deptDesc = "",
                deptName = a.DEPT_NAME,
                doctCode = a.DOCT_CODE,
                doctDesc = "",
                doctName = a.DOCT_NAME,
                endTime = a.END_TIME,
                id = a.ID,
                limit = a.BOOKING_LMT,
                noonCode = a.NOONCODE,
                noonName = a.NOONNAME,
                regCode = a.REGLEVL_CODE,
                regCost = a.TOT_COST,
                registered = a.TEL_REGED,
                regName = a.REGLEVL_NAME,
                regType = a.REGISTRATION_TYPE,
                sortId = a.SORTID,
                week = a.WEEK
            })?.ToArray());

            return new Gboxt.Common.DataModel.ApiArrayResult<ScheduleQueryResponseModel>
            {
                Success = result.state == 0,
                ResultData = result.data?.ToList()
            };
        }

        [Agebull.ZeroNet.ZeroApi.Route("api/default/test1")]
        public Gboxt.Common.DataModel.ApiResult<RegisterCancelResponseModel> Test1(RegisterCancelRequestModel request)
        {
            var hisRequest = new DTO.Hosp3005Request
            {
                clinicNo = request.clinicNo,
                operCode = request.operCode
            };

            var result = proxyService.Do<DTO.Hosp3005Request, DTO.Hosp3005Response, RegisterCancelResponseModel>(hisRequest, (p) => new RegisterCancelResponseModel
            {
                state = p.data == null ? 0 : p.data.state
            });

            return new Gboxt.Common.DataModel.ApiResult<RegisterCancelResponseModel>
            {
                Success = result.state == 0,
                ResultData = result.data
            };
        }
    }

    public interface ITestService
    {
        string Hello { get; }
    }

    public class TestService : ITestService
    {
        public string Hello => $"{Guid.NewGuid()}: hello, world!";
    }
}
