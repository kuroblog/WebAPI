
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
            var parseResult = await Request.ParseTo<TestRequestDto>();
            if (!parseResult.isParsed)
            {
                return await Task.FromResult(BadRequest(parseResult.error));
            }

            var result = await Runner.Execute(service.HisInterfaceTest, parseResult.data.GetRequestData<dynamic>());
            if (result.hasError)
            {
                return await Task.FromResult(StatusCode(500, result.error));
            }
            else
            {
                return await Task.FromResult(Ok(result.data));
            }
        }
    }
}