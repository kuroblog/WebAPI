
namespace Flysh.HospInterface.ProxyApi.His
{
    public class HisOptions
    {
        //public string Mode { get; set; }

        public HisInterfaceModes Mode { get; set; }

        public string Url { get; set; }
    }

    public enum HisInterfaceModes
    {
        WebService = 0x00,
        Socket = 0x01
    }
}
