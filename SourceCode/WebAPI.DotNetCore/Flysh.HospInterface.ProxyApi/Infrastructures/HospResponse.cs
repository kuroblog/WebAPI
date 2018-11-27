
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    /// <summary>
    /// his interface result
    /// </summary>
    public class HospResponse
    {
        /// <summary>
        /// his result
        /// </summary>
        public string Result { get; } = string.Empty;

        /// <summary>
        /// json format result
        /// </summary>
        public string FormatResult
        {
            get { return Result.Replace("\"[", "[").Replace("]\"", "]").Replace("\"{", "{").Replace("}\"", "}").Replace("\\\"", "\""); }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="hisResult"></param>
        public HospResponse(string hisResult)
        {
            Result = hisResult;
        }
    }
}
