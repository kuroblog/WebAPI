
namespace WebApp.CallWebService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly IHisProxyInterface svcProxy;

        public DefaultController(ProxyFactory svcFactory)
        {
            svcProxy = svcFactory.Instance;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var result = await svcProxy.DoTrans(new DoTransRequestDto<string>("4004", ""));

            return await Task.FromResult(result.JsonFormatResult);
        }
    }
}