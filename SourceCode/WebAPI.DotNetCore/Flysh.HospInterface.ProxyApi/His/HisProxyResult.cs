
namespace Flysh.HospInterface.ProxyApi.His
{
    public class HisProxyResult
    {
        public string HisResult { get; } = string.Empty;

        public string FormatResult
        {
            get { return HisResult.Replace("\"[", "[").Replace("]\"", "]").Replace("\"{", "{").Replace("}\"", "}").Replace("\\\"", "\""); }
        }

        public HisProxyResult(string hisResult)
        {
            HisResult = hisResult;
        }
    }
}
