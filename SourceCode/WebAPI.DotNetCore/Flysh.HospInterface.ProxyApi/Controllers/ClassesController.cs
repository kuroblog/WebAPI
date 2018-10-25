
namespace Flysh.HospInterface.ProxyApi.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Models;
    using Flysh.HospInterface.ProxyApi.Services;
    using Gboxt.Common.DataModel;

    /// <summary>
    /// classes
    /// </summary>
    public class ClassesController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        /// <summary>
        /// hello
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/classes/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        /// <summary>
        /// 获取排班信息
        /// </summary>
        /// <param name="request"><see cref="ClassesScheduleRequest"/></param>
        /// <returns><see cref="ClassesScheduleResponse"/></returns>
        [Route("api/v1/classes/schedule")]
        public ApiArrayResult<ClassesScheduleResponse> Schedule(ClassesScheduleRequest request)
        {
            return Runner.Execute(service.ClassesSchedule, request);
        }
    }
}