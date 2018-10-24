﻿
namespace Flysh.HospInterface.ProxyApi.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.Services;
    using Gboxt.Common.DataModel;

    public class DefaultController : ZeroApiController
    {
        private readonly ITestService testService = IocHelper.CreateScope<ITestService>();

        [Route("api/v1/default/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = testService.Message
            };
        }
    }
}