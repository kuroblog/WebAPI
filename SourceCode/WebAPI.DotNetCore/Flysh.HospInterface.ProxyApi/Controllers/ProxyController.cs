
namespace Flysh.HospInterface.ProxyApi.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.His.Dto;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Services;
    using Gboxt.Common.DataModel;

    /// <summary>
    /// his interface test
    /// </summary>
    public class ProxyController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        /// <summary>
        /// hello
        /// </summary>
        /// <returns></returns>
        [Route("api/v1/proxy/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        /// <summary>
        /// his do-trans webmethod
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("api/v1/proxy/test")]
        public ApiResult<string> Test(HisDoTransRequest<string> request)
        {
            return Runner.Execute(service.HisTest, request);
        }
    }
}