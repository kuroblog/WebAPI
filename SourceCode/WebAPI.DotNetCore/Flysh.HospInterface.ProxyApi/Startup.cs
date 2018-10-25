
namespace Flysh.HospInterface.ProxyApi
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.Core;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.His;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using Flysh.HospInterface.ProxyApi.Services;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            Agebull.Common.Configuration.ConfigurationManager.SetConfiguration(configuration);
            ZeroApplication.CheckOption();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            IocHelper.ServiceCollection.Configure<HisOptions>(Configuration.GetSection(nameof(HisOptions)));
            IocHelper.AddScoped<IHisProxyInterface, HisSocketProxy>();
            IocHelper.AddScoped<IHisProxyInterface, HisWebSvcProxy>();
            IocHelper.AddScoped<HisProxyFactory>();
            IocHelper.AddScoped<IProxyService, ProxyService>();
            
            ZeroApplication.Initialize();

            IAutoRegister iar = new AutoRegister();
            iar.Initialize();
            iar.AutoRegist();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Task.Factory.StartNew(ZeroApplication.Run);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
