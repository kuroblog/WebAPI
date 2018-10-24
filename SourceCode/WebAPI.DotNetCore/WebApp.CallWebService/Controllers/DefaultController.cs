
namespace WebApp.CallWebService.Controllers
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.ZeroApi;
    using Gboxt.Common.DataModel;
    using System;
    using System.Collections.Generic;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Extensions;
    using WebApp.CallWebService.Models;
    using WebApp.CallWebService.Services;

    public class DefaultController : ZeroApiController
    {
        private readonly IFoo msgSvc = IocHelper.CreateScope<IFoo>();

        private readonly IEnumerable<IFoo> msgSvcs = IocHelper.Create<IEnumerable<IFoo>>();

        private readonly IProxyService service = IocHelper.CreateScope<IProxyService>();

        //public DefaultController(IProxyService service)
        //{

        //}

        [Route("api/v1/default/hello")]
        public ApiResult Hello()
        {
            return new ApiResult<string>
            {
                Success = true,
                ResultData = msgSvc.Message
            };
        }

        [Route("api/v1/default/test")]
        public ApiResult Test(TestRequestDto<string> dto)
        {
            var result = Runner.Execute(service.HisInterfaceTest, dto.GetRequestData()).Result;
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