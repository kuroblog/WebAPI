
namespace WebApp.CallWebService.Services
{
    using Newtonsoft.Json;
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Models;

    public interface IProxyService
    {
        Task<dynamic> HisInterfaceTest(DoTransRequestDto<dynamic> param);
    }

    public class ProxyService : IProxyService
    {
        private readonly IHisProxyInterface service;

        public ProxyService(ProxyFactory proxyFactory)
        {
            service = proxyFactory.Instance;
        }

        public async Task<dynamic> HisInterfaceTest(DoTransRequestDto<dynamic> param)
        {
            var hisResult = await service.DoTrans(param);
            dynamic result = JsonConvert.DeserializeObject<dynamic>(hisResult.JsonFormatResult);

            return await Task.FromResult(result);
        }
    }
}
