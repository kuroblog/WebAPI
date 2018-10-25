
namespace Flysh.HospInterface.ProxyApi.His
{
    /// <summary>
    /// his interface result
    /// </summary>
    public class HisProxyResult
    {
        /// <summary>
        /// his result
        /// </summary>
        public string HisResult { get; } = string.Empty;

        /// <summary>
        /// json format result
        /// </summary>
        public string FormatResult
        {
            get { return HisResult.Replace("\"[", "[").Replace("]\"", "]").Replace("\"{", "{").Replace("}\"", "}").Replace("\\\"", "\""); }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="hisResult"></param>
        public HisProxyResult(string hisResult)
        {
            HisResult = hisResult;
        }
    }
}
