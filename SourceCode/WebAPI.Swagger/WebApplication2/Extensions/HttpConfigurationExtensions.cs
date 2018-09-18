
namespace WebApplication2
{
    using Microsoft.Web.Http.Routing;
    using Swashbuckle.Application;
    using Swashbuckle.Examples;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Http.Description;
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
            // we only need to change the default constraint resolver for services that want urls with versioning like: ~/v{version}/{controller}
            var constraintResolver = new DefaultInlineConstraintResolver()
            {
                ConstraintMap = { ["apiVersion"] = typeof(ApiVersionRouteConstraint) }
            };
            config.MapHttpAttributeRoutes(constraintResolver);

            // reporting api versions will return the headers "api-supported-versions" and "api-deprecated-versions"
            config.AddApiVersioning(p => p.ReportApiVersions = true);
        }

        private static Func<string> getXmlCommentsFilePath = () =>
        {
            var basePath = AppDomain.CurrentDomain.RelativeSearchPath;
            var fileName = typeof(HttpConfigurationExtensions).GetTypeInfo().Assembly.GetName().Name + ".xml";
            return Path.Combine(basePath, fileName);
        };

        /// <summary>
        /// enable swagger support multi-version
        /// </summary>
        /// <param name="config"><see cref="HttpConfiguration"/>http server's config</param>
        public static void EnableSwaggerSettings(this HttpConfiguration config)
        {
            // add the versioned IApiExplorer and capture the strongly-typed implementation (e.g. VersionedApiExplorer vs IApiExplorer)
            // note: the specified format code will format the version as "'v'major[.minor][-status]"
            var apiExplorer = config.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";

                // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                // can also be used to control the format of the API version in route templates
                options.SubstituteApiVersionInUrl = true;
            });

            config.EnableSwagger("{apiVersion}/swagger", swagger =>
            {
                swagger.OperationFilter<ExamplesOperationFilter>();

                // build a swagger document and endpoint for each discovered API version
                swagger.MultipleApiVersions((apiDescription, version) => apiDescription.GetGroupName() == version, info =>
                {
                    foreach (var group in apiExplorer.ApiDescriptions)
                    {
                        var description = "A sample application with Swagger, Swashbuckle, and API versioning.";

                        if (group.IsDeprecated)
                        {
                            description += " This API version has been deprecated.";
                        }

                        info.Version(group.Name, $"Sample API {group.ApiVersion}")
                            .Contact(c => c.Name("kuro").Email("kuro_q@somewhere.com"))
                            .Description(description)
                            .License(l => l.Name("MIT").Url("https://opensource.org/licenses/MIT"))
                            .TermsOfService("Shareware");
                    }
                });

                // add a custom operation filter which sets default values
                swagger.OperationFilter<SwaggerDefaultValues>();

                // integrate xml comments
                swagger.IncludeXmlComments(getXmlCommentsFilePath());
            }).EnableSwaggerUi(swagger => swagger.EnableDiscoveryUrlSelector());
        }
    }
}