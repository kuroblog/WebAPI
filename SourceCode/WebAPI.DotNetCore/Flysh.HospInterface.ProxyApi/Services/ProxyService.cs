
namespace Flysh.HospInterface.ProxyApi.Services
{
    using Flysh.HospInterface.ProxyApi.His;
    using Flysh.HospInterface.ProxyApi.His.Dto;
    using System.Threading.Tasks;

    public interface IProxyService
    {
        Task<string> HisInterfaceTest<TData>(HisDoTransRequest<TData> request);
    }

    public class ProxyService : IProxyService
    {
        private readonly IHisProxyInterface service;

        public ProxyService(HisProxyFactory proxyFactory)
        {
            service = proxyFactory.Instance;
        }

        public async Task<string> HisInterfaceTest<TData>(HisDoTransRequest<TData> request)
        {
            var hisResult = await service.DoTrans(request);

            return await Task.FromResult(hisResult.FormatResult);
        }
    }
}
