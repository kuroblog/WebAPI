
namespace Flysh.HospInterface.ProxyApi.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.His.Dto;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Services;
    using Gboxt.Common.DataModel;
    using System;

    public class ProxyController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();
        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/proxy/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }

        [Route("api/v1/proxy/test")]
        public ApiResult Test(HisDoTransRequest<string> request)
        {
            var result = Runner.Execute(service.HisInterfaceTest, request).Result;
            if (result.hasError)
            {
                return new ApiResult<Exception> { Success = false, ResultData = result.error };
            }
            else
            {
                return new ApiResult<string> { Success = true, ResultData = result.data };
            }
        }
    }
}