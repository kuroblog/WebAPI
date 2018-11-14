using Agebull.ZeroNet.ZeroApi;
using System;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers
{
    public class DefaultController : ApiController
    {
        private readonly ITestService tService = Agebull.Common.Ioc.IocHelper.CreateScope<ITestService>();

        [Route("api/default/hello")]
        public Gboxt.Common.DataModel.ApiResult Hello()
        {
            return new Gboxt.Common.DataModel.ApiResult<string>
            {
                ResultData = tService.Hello
            };
        }
    }

    public interface ITestService
    {
        string Hello { get; }
    }

    public class TestService : ITestService
    {
        public string Hello => $"{Guid.NewGuid()}: hello, world!";
    }
}
