
namespace Flysh.HospInterface.ProxyApi.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Models;
    using Flysh.HospInterface.ProxyApi.Services;
    using Gboxt.Common.DataModel;

    /// <summary>
    /// 排班
    /// </summary>
    public class ClassController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        /// <summary>
        /// hello
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/class/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        /// <summary>
        /// 排班信息
        /// </summary>
        /// <param name="request"><see cref="ClassScheduleRequest"/></param>
        /// <returns><see cref="ClassScheduleData"/></returns>
        [Route("api/v1/class/schedule")]
        public ApiArrayResult<ClassScheduleData> Schedule(ClassScheduleRequest request)
        {
            return Runner.Execute(service.ClassSchedule, request);
        }

        /// <summary>
        /// 预约时间点信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/class/point")]
        public ApiArrayResult<string> Point(ClassPointRequest request)
        {
            return Runner.Execute(service.ClassPoint, request);
        }
    }
}