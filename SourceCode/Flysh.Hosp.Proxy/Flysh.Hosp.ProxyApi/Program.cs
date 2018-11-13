using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Flysh.Hosp.ProxyApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            Agebull.ZeroNet.Core.ZeroApplication.Shutdown();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
