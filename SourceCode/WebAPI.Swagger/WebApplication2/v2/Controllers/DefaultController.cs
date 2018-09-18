
namespace WebApplication2.v2.Controllers
{
    using Microsoft.Web.Http;

    /// <summary>
    /// default api
    /// </summary>
    [ApiVersion(ApiVersion)]
    public class DefaultController : v1.Controllers.DefaultController
    {
        /// <summary>
        /// api version
        /// </summary>
        public new const string ApiVersion = "2.0";
    }
}
