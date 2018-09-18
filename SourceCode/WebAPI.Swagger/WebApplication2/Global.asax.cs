
namespace WebApplication2
{
    using System.Web;
    using System.Web.Http;

    /// <summary>
    /// webapi application
    /// </summary>
    public class WebApiApplication : HttpApplication
    {
        /// <summary>
        /// start event
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
