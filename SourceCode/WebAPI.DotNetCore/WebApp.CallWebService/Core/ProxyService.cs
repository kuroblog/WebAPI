
namespace WebApp.CallWebService.Core
{
    using System.Threading.Tasks;
    using WebApp.CallWebService.Models;

    public class ProxyService
    {
        private readonly IHisProxyInterface service;

        public ProxyService(ProxyFactory proxyFactory)
        {
            service = proxyFactory.Instance;
        }

        public async Task<string> GetShemaInfo(string str)
        {
            var result = await service.DoTrans(new DoTransRequestDto<dynamic>("2003", new
            {
                beginDate = "2015-01-01",
                endDate = "2015-21-01",
                isPre = "1"
            }));
            return await Task.FromResult(result.JsonFormatResult);
        }
    }
}
