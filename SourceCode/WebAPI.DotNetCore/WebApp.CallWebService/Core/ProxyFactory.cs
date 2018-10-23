
namespace WebApp.CallWebService.Core
{
    using Microsoft.Extensions.Options;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class ProxyFactory
    {
        public IHisProxyInterface Instance { get; }

        public ProxyFactory(IEnumerable<IHisProxyInterface> proxyArray, IOptions<HisOptions> hisOptions)
        {
            var hisMode = hisOptions.Value.Mode;
            Instance = proxyArray.FirstOrDefault(p => string.Compare(p.Name, hisMode) == 0);
        }
    }
}
