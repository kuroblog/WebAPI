
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    using Agebull.Common.Ioc;
    using Agebull.ZeroNet.Core;
    using Agebull.ZeroNet.ZeroApi;
    using Flysh.HospInterface.ProxyApi.Services;
    using System.ComponentModel.Composition;

    /// <summary>
    /// 
    /// </summary>
    [Export(typeof(IAutoRegister))]
    [ExportMetadata("Symbol", '%')]
    public sealed class AutoRegister : IAutoRegister
    {
        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            IocHelper.AddSingleton<ITestService, TestService>();
        }

        /// <summary>
        /// 
        /// </summary>
        public void AutoRegist()
        {
            ZeroApplication.Discove(GetType().Assembly);
        }
    }
}
