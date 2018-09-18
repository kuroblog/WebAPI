
namespace WebApplication2
{
    using Microsoft.Web.Http.Routing;
    using System.Web.Http;
    using System.Web.Http.Routing;

    /// <summary>
    /// http configuration extensions
    /// </summary>
    public static class HttpConfigurationExtensions
    {
        /// <summary>
        /// map api version routes
        /// </summary>
        /// <param name="config"><see cref="HttpConfiguration"/>http server's config</param>
        public static void MapApiVersionRoutes(this HttpConfiguration config)
        {
            var constraintResolver = new DefaultInlineConstraintResolver()
            {
                ConstraintMap = { ["apiVersion"] = typeof(ApiVersionRouteConstraint) }
            };
            config.MapHttpAttributeRoutes(constraintResolver);

            config.AddApiVersioning(p => p.ReportApiVersions = true);
        }
    }
}