
namespace Flysh.HospInterface.ProxyApi.His
{
    /// <summary>
    /// 
    /// </summary>
    public class HisOptions
    {
        //public string Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HisInterfaceModes Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum HisInterfaceModes
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
