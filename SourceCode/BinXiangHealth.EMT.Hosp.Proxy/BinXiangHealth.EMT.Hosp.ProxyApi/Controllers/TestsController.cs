using BinXiangHealth.EMT.Hosp.ProxyApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ITestService testService = null;

        public TestsController(ITestService testService)
        {
            this.testService = testService;
        }

        [HttpPost]
        public ActionResult<(string result, string json, string error)> Post([FromBody]TestRequestDto dto)
        {
            var result = testService.Test(dto.code, dto.param);
            return Ok(result);
        }


        [HttpGet]
        public ActionResult<(string result, string json, string error)> Get([FromQuery]string cardNo)
        {
            var result = testService.GetRegisters(new
            {
                cardNo
            });
            return Ok(result);
        }
    }

    public class TestRequestDto
    {
        public string code { get; set; }

        public dynamic param { get; set; }
    }

    public class TestResponseDto
    {
        public string code { get; set; }

        public dynamic request { get; set; }

        public dynamic response { get; set; }

        public string result { get; set; }

        public dynamic error { get; set; }
    }
}
