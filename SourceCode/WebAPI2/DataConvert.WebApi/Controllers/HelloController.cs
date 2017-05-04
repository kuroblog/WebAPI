
namespace DataConvert.WebApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class HelloController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Hello([FromUri]string user = "guest")
        {
            var resultMessage = await Task.FromResult($"Hello {user}, Welcome to access my api on {DateTime.UtcNow}");

            return Ok(resultMessage);
        }
    }
}
