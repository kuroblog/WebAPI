
namespace Flysh.HospInterface.ProxyApi.His
{
    using Flysh.HospInterface.ProxyApi.His.Dto;
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

        Task<HisProxyResult> DoTrans<TRequestData>(DoTransDto<TRequestData> requestData);
    }

    public sealed class HisProxyFactory
    {
        public IHisProxyInterface Instance { get; }

        public HisProxyFactory(IEnumerable<IHisProxyInterface> proxyArray, IOptions<HisOptions> hisOptions)
        {
            var hisMode = hisOptions.Value.Mode;
            Instance = proxyArray.FirstOrDefault(p => string.Compare(p.Name, hisMode) == 0);
        }
    }

    public class HisSocketProxy : IHisProxyInterface
    {
        public string Name => "Socket";

        public Task<HisProxyResult> DoTrans<TRequestData>(DoTransDto<TRequestData> requestData)
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

        private TSoapProxyService GenerateSoapClient<TSoapProxyService>()
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

            var soapFactory = new ChannelFactory<TSoapProxyService>(binding, endpoint);
            var soapClient = soapFactory.CreateChannel();

            return soapClient;
        }

        public async Task<HisProxyResult> DoTrans<TRequestData>(DoTransDto<TRequestData> requestData)
        {
            var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();
            var soapResult = await soapClient.DoTransAsync(requestData.Body);

            return await Task.FromResult(new HisProxyResult(soapResult.Body.DoTransResult));
        }
    }
}
