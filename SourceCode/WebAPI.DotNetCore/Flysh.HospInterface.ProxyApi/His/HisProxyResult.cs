
namespace Flysh.HospInterface.ProxyApi.His
{
    public class HisProxyResult
    {
        public string SourceResult { get; } = string.Empty;

        public string JsonFormatResult
        {
            get { return SourceResult.Replace("\"[", "[").Replace("]\"", "]").Replace("\"{", "{").Replace("}\"", "}").Replace("\\\"", "\""); }
        }

        public HisProxyResult(string sourceResult)
        {
            SourceResult = sourceResult;
        }
    }
}
