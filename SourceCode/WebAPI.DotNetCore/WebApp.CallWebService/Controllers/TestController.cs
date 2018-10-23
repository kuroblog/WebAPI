
namespace WebApp.CallWebService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ProxyService service;

        public TestController(ProxyService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var result = await Runner.Execute(service.GetShemaInfo, "");

            return await Task.FromResult(result);
        }
    }
}