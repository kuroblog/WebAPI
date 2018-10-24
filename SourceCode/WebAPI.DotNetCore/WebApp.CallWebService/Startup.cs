
namespace WebApp.CallWebService
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.Core;
    using Agebull.ZeroNet.ZeroApi;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Services;

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
            #region iochelper
            IocHelper.ServiceCollection.Configure<HisOptions>(Configuration.GetSection(nameof(HisOptions)));
            IocHelper.AddScoped<IHisProxyInterface, HisSocketProxy>();
            IocHelper.AddScoped<IHisProxyInterface, HisWebSvcProxy>();
            IocHelper.AddScoped<ProxyFactory>();
            IocHelper.AddScoped<IProxyService, ProxyService>();

            ZeroApplication.Initialize();
            #endregion

            #region standard
            //services.AddOptions();
            //services.Configure<HisOptions>(Configuration.GetSection(nameof(HisOptions)));

            //services.AddScoped<IHisProxyInterface, HisSocketProxy>();
            //services.AddScoped<IHisProxyInterface, HisWebSvcProxy>();
            //services.AddScoped<ProxyFactory>();
            //services.AddScoped<IProxyService, ProxyService>();
            #endregion

            var i = new AutoRegister() as IAutoRegister;
            i.Initialize();
            i.AutoRegist();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //services.AddScoped<IFoo, Foo>();
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
