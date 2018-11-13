namespace Flysh.Hosp.ProxyApi
{
    public class HospProxySettings
    {
        public HospProxyModes Mode { get; set; }

        public string Url { get; set; }
    }

    public enum HospProxyModes
    {
        WebService = 0x00,
        Socket = 0x01
    }
}
