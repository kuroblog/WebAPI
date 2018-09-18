using Microsoft.Web.Http.Routing;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Http.Description;
using Swashbuckle.Application;
using Swashbuckle.Examples;

namespace WebApplication1
{
    /// <summary>
    /// 
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            //config.MapHttpAttributeRoutes();

            var constraintResolver = new DefaultInlineConstraintResolver()
            {
                ConstraintMap = { ["apiVersion"] = typeof(ApiVersionRouteConstraint) }
            };
            config.MapHttpAttributeRoutes(constraintResolver);
            config.AddApiVersioning(p => p.ReportApiVersions = true);

            var apiExplorer = config.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            config.EnableSwagger("{apiVersion}/swagger", swagger =>
            {
                swagger.OperationFilter<ExamplesOperationFilter>();

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
                            .Contact(c => c.Name("Bill Mei").Email("bill.mei@somewhere.com"))
                            .Description(description)
                            .License(l => l.Name("MIT").Url("https://opensource.org/licenses/MIT"))
                            .TermsOfService("Shareware");
                    }
                });

                swagger.OperationFilter<SwaggerDefaultValues>();

                swagger.IncludeXmlComments(XmlCommentsFilePath);
            }).EnableSwaggerUi(swagger => swagger.EnableDiscoveryUrlSelector());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        static string XmlCommentsFilePath
        {
            get
            {
                var basePath = AppDomain.CurrentDomain.RelativeSearchPath;
                var fileName = typeof(WebApiConfig).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SwaggerDefaultValues : IOperationFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                return;
            }

            foreach (var parameter in operation.parameters)
            {
                var description = apiDescription.ParameterDescriptions.First(p => p.Name == parameter.name);

                // REF: https://github.com/domaindrivendev/Swashbuckle/issues/1101
                if (parameter.description == null)
                {
                    parameter.description = description.Documentation;
                }

                // REF: https://github.com/domaindrivendev/Swashbuckle/issues/1089
                // REF: https://github.com/domaindrivendev/Swashbuckle/pull/1090
                if (parameter.@default == null)
                {
                    parameter.@default = description.ParameterDescriptor?.DefaultValue;
                }
            }
        }
    }
}
