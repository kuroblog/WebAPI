using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.ServiceModel;
using System.Xml;

namespace BinXiangHealth.EMT.Hosp.ProxyApi
{
    public interface IHospProxyService
    {
        TResponse Invoke<TRequest, TResponse>(TRequest request)
            where TRequest : IHospProxyRequestModel, new()
            where TResponse : IHospProxyResponseModel, new();
    }

    public class HospWebProxyService : IHospProxyService
    {
        private readonly string url = string.Empty;

        public HospWebProxyService(IOptions<HospProxySettings> proxySettings)
        {
            url = proxySettings.Value.Url;
        }

        public TResponse Invoke<TRequest, TResponse>(TRequest request)
            where TRequest : IHospProxyRequestModel, new()
            where TResponse : IHospProxyResponseModel, new()
        {
            var soapRequest = request.ConvertToHospRequest();
#if DEBUG
            Console.WriteLine(soapRequest);
#endif

            var soapClient = GenerateSoapClient<AppServiceCommonSoap>();
            var soapResult = soapClient.DoTransAsync(soapRequest.code, soapRequest.json).Result;
#if DEBUG
            Console.WriteLine(soapResult);
#endif

            var result = JsonConvert.DeserializeObject<TResponse>(soapResult.FormatHospResult());
#if DEBUG
            Console.WriteLine(result);
#endif

            return result;
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
    }
}
