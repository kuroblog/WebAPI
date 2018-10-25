
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
        HisInterfaceModes HisInterfaceMode { get; }

        Task<HisProxyResult> DoTransAsync<TData>(HisDoTransRequest<TData> data);

        HisProxyResult DoTrans<TData>(HisDoTransRequest<TData> data);
    }

    public sealed class HisProxyFactory
    {
        public IHisProxyInterface Instance { get; }

        public HisProxyFactory(IEnumerable<IHisProxyInterface> proxyArray, IOptions<HisOptions> hisOptions)
        {
            var hisInterfaceMode = hisOptions.Value.Mode;
            Instance = proxyArray.FirstOrDefault(p => p.HisInterfaceMode == hisInterfaceMode);
        }
    }

    public class HisSocketProxy : IHisProxyInterface
    {
        public HisInterfaceModes HisInterfaceMode => HisInterfaceModes.Socket;

        public Task<HisProxyResult> DoTransAsync<TData>(HisDoTransRequest<TData> data)
        {
            throw new NotImplementedException();
        }

        public HisProxyResult DoTrans<TData>(HisDoTransRequest<TData> data)
        {
            throw new NotImplementedException();
        }
    }

    public class HisWebSvcProxy : IHisProxyInterface
    {
        public HisInterfaceModes HisInterfaceMode => HisInterfaceModes.WebService;

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

        public async Task<HisProxyResult> DoTransAsync<TData>(HisDoTransRequest<TData> data)
        {
            //var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();

            //var doTransRequest = data.GetRequestData<HisDoTransRequest<TData>, TData>();

            //var soapResult = await soapClient.DoTransAsync(doTransRequest);

            //return await Task.FromResult(new HisProxyResult(soapResult.Body.DoTransResult));

            return await Task.FromResult(DoTrans(data));
        }

        public HisProxyResult DoTrans<TData>(HisDoTransRequest<TData> data)
        {
            var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();

            var doTransRequest = data.GetRequestData<HisDoTransRequest<TData>, TData>();

            var soapResult = soapClient.DoTransAsync(doTransRequest).Result;

            return new HisProxyResult(soapResult.Body.DoTransResult);
        }
    }
}
