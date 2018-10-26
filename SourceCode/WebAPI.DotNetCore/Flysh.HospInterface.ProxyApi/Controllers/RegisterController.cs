
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
    public class RegisterController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        /// <summary>
        /// hello
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/register/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/register/submit")]
        public ApiResult<RegisterSubmitData> Submit(RegisterSubmitRequest request)
        {
            return Runner.Execute(service.RegisterSubmit, request);
        }

        /// <summary>
        /// 挂号取消
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/register/cancel")]
        public ApiResult<bool> Cancel(RegisterCancelRequest request)
        {
            return Runner.Execute(service.RegisterCancel, request);
        }

        ///// <summary>
        ///// 预约查询
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //[Route("api/v1/subscribe/query")]
        //public ApiResult<SubscribeQueryData> Query(SubscribeQueryRequest request)
        //{
        //    return Runner.Execute(service.SubscribeQuery, request);
        //}
    }
}