
namespace Flysh.HospInterface.ProxyApi.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Models;
    using Flysh.HospInterface.ProxyApi.Services;
    using Gboxt.Common.DataModel;

    /// <summary>
    /// 卡号
    /// </summary>
    public class CardController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        /// <summary>
        /// hello
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/card/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        /// <summary>
        /// 卡号查询
        /// </summary>
        /// <param name="request"><see cref="ClassScheduleRequest"/></param>
        /// <returns><see cref="ClassScheduleData"/></returns>
        [Route("api/v1/card/query")]
        public ApiResult<CardQueryData> Query(CardQueryRequest request)
        {
            return Runner.Execute(service.CardQuery, request);
        }
    }
}