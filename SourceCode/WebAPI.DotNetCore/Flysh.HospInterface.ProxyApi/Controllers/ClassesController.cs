
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
        /// 排班信息
        /// </summary>
        /// <param name="request"><see cref="ClassesScheduleRequest"/></param>
        /// <returns><see cref="ClassesScheduleData"/></returns>
        [Route("api/v1/classes/schedule")]
        public ApiArrayResult<ClassesScheduleData> Schedule(ClassesScheduleRequest request)
        {
            return Runner.Execute(service.ClassesSchedule, request);
        }

        /// <summary>
        /// 预约时间点信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/classes/point")]
        public ApiArrayResult<string> Point(ClassesPointRequest request)
        {
            return Runner.Execute(service.ClassesPoint, request);
        }

        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/classes/subscribe")]
        public ApiResult<ClassesSubscribeData> Subscribe(ClassesSubscribeRequest request)
        {
            return Runner.Execute(service.ClassesSubscribe, request);
        }

        /// <summary>
        /// 预约取消
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/classes/subscribe/cancel")]
        public ApiResult<bool> SubscribeCancel(ClassesSubscribeCancelRequest request)
        {
            return Runner.Execute(service.ClassesSubscribeCancel, request);
        }

        /// <summary>
        /// 预约查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/classes/subscribe/query")]
        public ApiResult<ClassesSubscribeQueryData> SubscribeQuery(ClassesSubscribeQueryRequest request)
        {
            return Runner.Execute(service.ClassesSubscribeQuery, request);
        }
    }
}