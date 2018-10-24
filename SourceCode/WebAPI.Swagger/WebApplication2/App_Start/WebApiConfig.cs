
namespace WebApplication2
{
    using System.Web.Http;

    /// <summary>
    /// webapi config
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// register
        /// </summary>
        /// <param name="config"><see cref="HttpConfiguration"/>http server's config</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            //config.MapHttpAttributeRoutes();
            config.MapApiVersionRoutes();

            config.EnableSwaggerSettings();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
