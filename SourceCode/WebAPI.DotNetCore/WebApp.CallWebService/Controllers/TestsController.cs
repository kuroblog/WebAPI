
namespace WebApp.CallWebService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Extensions;
    using WebApp.CallWebService.Models;
    using WebApp.CallWebService.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ProxyService service;

        public TestsController(ProxyService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.FromResult(Ok($"{DateTime.Now.ToString()}: {Guid.NewGuid()}"));
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var requestParam = await Request.ParseTo<TestRequestDto>();

            var result = await Runner.Execute(service.HisInterfaceTest, requestParam.GetRequestData<dynamic>());

            return await Task.FromResult(Ok(result));
        }
    }
}