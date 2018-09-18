
namespace WebApplication2
{
    using System.Web.Http;

    /// <summary>
    /// api extensions
    /// </summary>
    public static class ApiControllerExtensions
    {
        /// <summary>
        /// get api version
        /// </summary>
        /// <param name="api">api</param>
        /// <returns>version</returns>
        public static string GetVersion(this ApiController api)
        {
            object ver = string.Empty;
            var isSuccessful = api?.RequestContext?.RouteData?.Values?.TryGetValue("version", out ver);

            return isSuccessful.HasValue && isSuccessful.Value ? ver.ToString() : string.Empty;
        }
    }
}