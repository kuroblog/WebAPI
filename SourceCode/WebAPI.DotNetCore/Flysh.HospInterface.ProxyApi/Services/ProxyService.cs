
namespace Flysh.HospInterface.ProxyApi.Services
{
    using Flysh.HospInterface.ProxyApi.His;
    using System.Threading.Tasks;

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
