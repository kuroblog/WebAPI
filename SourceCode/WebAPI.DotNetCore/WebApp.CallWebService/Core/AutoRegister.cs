
namespace WebApp.CallWebService.Core
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.Core;
    using Agebull.ZeroNet.ZeroApi;
    using System.ComponentModel.Composition;

    /// <summary>
    ///   远程记录器
    /// </summary>
    [Export(typeof(IAutoRegister))]
    [ExportMetadata("Symbol", '%')]
    public sealed class AutoRegister : IAutoRegister
    {
        /// <summary>
        /// 初始化
        /// </summary>
        void IAutoRegister.Initialize()
        {
            //services.AddOptions();
            //services.Configure<HisOptions>(Configuration.GetSection(nameof(HisOptions)));

            IocHelper.AddSingleton<IFoo, Foo>();
            IocHelper.AddSingleton<IFoo, FooEx>();

            //IocHelper.AddSingleton<HisOptions>(Agebull.Common.Configuration.ConfigurationManager.SetConfiguration(nameof(HisOptions)));
        }

        /// <summary>
        /// 注册
        /// </summary>
        void IAutoRegister.AutoRegist()
        {
            ZeroApplication.Discove(GetType().Assembly);
        }
    }

    public interface IFoo
    {
        string Message { get; }
    }

    public class Foo : IFoo
    {
        public string Message => "hello world!";
    }

    public class FooEx : IFoo
    {
        public string Message => "no message!";
    }
}
