
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
    public class SubscribeController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        /// <summary>
        /// hello
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/subscribe/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/subscribe/submit")]
        public ApiResult<SubscribeSubmitData> Submit(SubscribeSubmitRequest request)
        {
            return Runner.Execute(service.SubscribeSubmit, request);
        }

        /// <summary>
        /// 预约取消
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/subscribe/cancel")]
        public ApiResult<bool> Cancel(SubscribeCancelRequest request)
        {
            return Runner.Execute(service.SubscribeCancel, request);
        }

        /// <summary>
        /// 预约查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/subscribe/query")]
        public ApiResult<SubscribeQueryData> Query(SubscribeQueryRequest request)
        {
            return Runner.Execute(service.SubscribeQuery, request);
        }
    }
}