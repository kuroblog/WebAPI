namespace Flysh.Hosp.ProxyApi.Controllers
{
    public class DefaultController : Agebull.ZeroNet.ZeroApi.ZeroApiController
    {
        [Agebull.ZeroNet.ZeroApi.Route("api/default/hello")]
        public Gboxt.Common.DataModel.ApiResult Hello()
        {
            return new Gboxt.Common.DataModel.ApiResult<string>
            {
                ResultData = "hello, world!"
            };
        }
    }
}
