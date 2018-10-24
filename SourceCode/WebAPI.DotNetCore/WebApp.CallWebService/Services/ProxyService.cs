
namespace WebApp.CallWebService.Services
{
    using System.Threading.Tasks;
    using WebApp.CallWebService.Core;
    using WebApp.CallWebService.Models;

    public interface IProxyService
    {
        Task<string> HisInterfaceTest<TData>(DoTransRequestDto<TData> param);
    }

    public class ProxyService : IProxyService
    {
        private readonly IHisProxyInterface service;

        public ProxyService(ProxyFactory proxyFactory)
        {
            service = proxyFactory.Instance;
        }

        public async Task<string> HisInterfaceTest<TData>(DoTransRequestDto<TData> param)
        {
            var hisResult = await service.DoTrans(param);

            //dynamic result = JsonConvert.DeserializeObject<dynamic>(hisResult.JsonFormatResult);
            //return await Task.FromResult(result);

            return await Task.FromResult(hisResult.JsonFormatResult);
        }
    }
}
