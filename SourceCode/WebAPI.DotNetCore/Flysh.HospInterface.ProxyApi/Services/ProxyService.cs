
namespace Flysh.HospInterface.ProxyApi.Services
{
    using Flysh.HospInterface.ProxyApi.His;
    using Flysh.HospInterface.ProxyApi.His.Dto;
    using System.Threading.Tasks;

    public interface IProxyService
    {
        Task<string> HisInterfaceTest<TRequestData>(DoTransDto<TRequestData> requestData);
    }

    public class ProxyService : IProxyService
    {
        private readonly IHisProxyInterface service;

        public ProxyService(HisProxyFactory proxyFactory)
        {
            service = proxyFactory.Instance;
        }

        public async Task<string> HisInterfaceTest<TRequestData>(DoTransDto<TRequestData> requestData)
        {
            var hisResult = await service.DoTrans(requestData);

            //dynamic result = JsonConvert.DeserializeObject<dynamic>(hisResult.JsonFormatResult);
            //return await Task.FromResult(result);

            return await Task.FromResult(hisResult.FormatResult);
        }
    }
}
