
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
    public class FeeController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        /// <summary>
        /// hello
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/fee/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        /// <summary>
        /// 挂号缴费记录查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/fee/register/query")]
        public ApiArrayResult<FeeRegisterQueryData> RegisterQuery(FeeRegisterQueryRequest request)
        {
            return Runner.Execute(service.FeeRegisterQuery, request);
        }
    }
}