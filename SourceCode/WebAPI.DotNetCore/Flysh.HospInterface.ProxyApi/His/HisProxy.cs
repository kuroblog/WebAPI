
namespace Flysh.HospInterface.ProxyApi.His
{
    using JHWR;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Threading.Tasks;
    using System.Xml;

    public interface IHisProxyInterface
    {
        string Name { get; }

        Task<HisProxyResult> DoTrans<TRequestDto>(DoTransRequestDto<TRequestDto> requestDto);
    }

    public sealed class ProxyFactory
    {
        public IHisProxyInterface Instance { get; }

        public ProxyFactory(IEnumerable<IHisProxyInterface> proxyArray, IOptions<HisOptions> hisOptions)
        {
            var hisMode = hisOptions.Value.Mode;
            Instance = proxyArray.FirstOrDefault(p => string.Compare(p.Name, hisMode) == 0);
        }
    }

    public class HisSocketProxy : IHisProxyInterface
    {
        public string Name => "Socket";

        public Task<HisProxyResult> DoTrans<TRequestDto>(DoTransRequestDto<TRequestDto> requestDto)
        {
            throw new NotImplementedException();
        }
    }

    public class HisWebSvcProxy : IHisProxyInterface
    {
        public string Name => "WebService";

        private readonly string url = string.Empty;

        public HisWebSvcProxy(IOptions<HisOptions> hisOptions)
        {
            url = hisOptions.Value.Url;
        }

        private TSoap GenerateSoapClient<TSoap>()
        {
            var binding = new BasicHttpBinding
            {
                ReceiveTimeout = new TimeSpan(0, 0, 60),
                SendTimeout = new TimeSpan(0, 2, 0),
                MaxReceivedMessageSize = int.MaxValue,
                MaxBufferPoolSize = int.MaxValue,
                MaxBufferSize = int.MaxValue,
                ReaderQuotas = XmlDictionaryReaderQuotas.Max
            };

            binding.Security.Mode = BasicHttpSecurityMode.None;

            var endpoint = new EndpointAddress(url);

            var soapFactory = new ChannelFactory<TSoap>(binding, endpoint);
            var soapClient = soapFactory.CreateChannel();

            return soapClient;
        }

        public async Task<HisProxyResult> DoTrans<TRequestDto>(DoTransRequestDto<TRequestDto> requestDto)
        {
            var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();
            var soapResult = await soapClient.DoTransAsync(requestDto.Body);

            return await Task.FromResult(new HisProxyResult(soapResult.Body.DoTransResult));
        }
    }
}
