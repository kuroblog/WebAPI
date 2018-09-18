
namespace WebApplication2
{
    /// <summary>
    /// version route settings
    /// </summary>
    public class VersionRouteSettings
    {
        private const string apiVersionRoutePrefix = "api/v{version:apiVersion}/";

        /// <summary>
        /// default api version route
        /// </summary>
        public const string DefaultApiVersion = apiVersionRoutePrefix + "default";
    }
}