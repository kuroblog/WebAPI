
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    /// <summary>
    /// 
    /// </summary>
    public class HospProxySettings
    {
        //public string Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HospProxyModes Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum HospProxyModes
    {
        /// <summary>
        /// 
        /// </summary>
        WebService = 0x00,
        /// <summary>
        /// 
        /// </summary>
        Socket = 0x01
    }
}
