
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    using Gboxt.Common.DataModel;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class HospRequest<TData> : IApiArgument
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual TData data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HospRequest(string code, TData data)
        {
            this.code = code;
            this.data = data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Validate(out string message)
        {
            message = string.Empty;

            return string.IsNullOrEmpty(message);
        }
    }
}
