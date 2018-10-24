
namespace WebApplication2.v1.Controllers
{
    using Microsoft.Web.Http;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Description;

    /// <summary>
    /// default api
    /// </summary>
    [ApiVersion(ApiVersion)]
    //[Route("api/v{version:apiVersion}/default")]
    [Route(VersionRouteSettings.DefaultApiVersion)]
    public class DefaultController : ApiController
    {
        /// <summary>
        /// api version
        /// </summary>
        public const string ApiVersion = "1.0";

        /// <summary>
        /// get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(string))]
        public async virtual Task<IHttpActionResult> Get()
        {
            var result = Content(HttpStatusCode.OK, $"{nameof(DefaultController)}; version: {this.GetVersion()}");
            return await Task.FromResult(result);
        }
    }
}
