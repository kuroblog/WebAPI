
namespace WebApp.CallWebService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;

    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly IHisSvcProxyInterface svcProxy;

        public DefaultController(ServiceFactory svcFactory)
        {
            svcProxy = svcFactory.Instance;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var result = await svcProxy.DoTrans(new DoTransArgs("4004", ""));

            return await Task.FromResult(result.JsonResult);
        }
    }
}