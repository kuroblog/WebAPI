
namespace Flysh.HospInterface.ProxyApi.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Models;
    using Flysh.HospInterface.ProxyApi.Services;
    using Gboxt.Common.DataModel;
    using Microsoft.Extensions.Options;

    public class ClassesController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/classes/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        [Route("api/v1/classes/schedule")]
        public ApiResult<ClassesScheduleResponse[]> Schedule(ClassesScheduleRequest request)
        {
            if (request == null)
            {
                return ApiResult<ClassesScheduleResponse[]>.ErrorResult(1001);
            }

            var result = Runner.Execute(service.ClassesSchedule, request);

            if (result.hasError)
            {
                return ApiResult<ClassesScheduleResponse[]>.ErrorResult(1001);
            }
            else
            {
                return new ApiResult<ClassesScheduleResponse[]> { Success = true, ResultData = result.data };
            }
        }
    }
}