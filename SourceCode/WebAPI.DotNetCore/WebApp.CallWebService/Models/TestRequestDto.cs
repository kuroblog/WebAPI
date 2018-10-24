
namespace WebApp.CallWebService.Models
{
    using Gboxt.Common.DataModel;

    public class TestRequestDto<TData> : IApiArgument
    {
        public string code { get; set; }

        public TData data { get; set; }

        public bool Validate(out string message)
        {
            message = string.Empty;

            return true;
        }
    }
}
