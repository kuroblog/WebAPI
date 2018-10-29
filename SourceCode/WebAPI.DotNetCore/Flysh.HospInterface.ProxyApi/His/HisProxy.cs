
namespace Flysh.HospInterface.ProxyApi.His
{
    using Agebull.Common.Logging;
    using Flysh.HospInterface.ProxyApi.Infrastructures;
    using JHWR;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Xml;

    /// <summary>
    /// his proxy factory
    /// </summary>
    /// <remarks>
    /// create webservice or socket instance
    /// </remarks>
    public sealed class HisProxyFactory
    {
        /// <summary>
        /// his proxy instance
        /// </summary>
        public IHospProxyInterface Instance { get; }

        /// <summary>
        /// construct
        /// </summary>
        /// <param name="proxies">proxy array</param>
        /// <param name="proxySettings">proxy settings</param>
        public HisProxyFactory(IEnumerable<IHospProxyInterface> proxies, IOptions<HospProxySettings> proxySettings)
        {
            var hisInterfaceMode = proxySettings.Value.Mode;
            Instance = proxies.FirstOrDefault(p => p.HisInterfaceMode == hisInterfaceMode);
        }
    }

    /// <summary>
    /// his socket proxy
    /// </summary>
    public class HisSocketProxy : IHospProxyInterface
    {
        /// <summary>
        /// proxy mode
        /// </summary>
        public HospProxyModes HisInterfaceMode => HospProxyModes.Socket;

        /// <summary>
        /// invoke service method
        /// </summary>
        /// <typeparam name="TData">request</typeparam>
        /// <param name="data">request data</param>
        /// <returns></returns>
        public HospResponse Invoke<TData>(HospRequest<TData> data)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisWebSvcProxy : IHospProxyInterface
    {
        /// <summary>
        /// proxy mode
        /// </summary>
        public HospProxyModes HisInterfaceMode => HospProxyModes.WebService;

        private readonly string url = string.Empty;

        /// <summary>
        /// construct
        /// </summary>
        /// <param name="proxySettings"></param>
        public HisWebSvcProxy(IOptions<HospProxySettings> proxySettings)
        {
            url = proxySettings.Value.Url;
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

        //public async Task<HospResponse> DoTransAsync<TData>(HospRequest<TData> data)
        //{
        //    //var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();
        //    //var doTransRequest = data.GetRequestData<HisDoTransRequest<TData>, TData>();
        //    //var soapResult = await soapClient.DoTransAsync(doTransRequest);
        //    //return await Task.FromResult(new HisProxyResult(soapResult.Body.DoTransResult));
        //    return await Task.FromResult(Invoke(data));
        //}

        /// <summary>
        /// invoke service method
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public HospResponse Invoke<TData>(HospRequest<TData> data)
        {
            var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();
            var request = data.GetRequestData<HospRequest<TData>, TData>();
            var soapResult = soapClient.DoTransAsync(request).Result;

            var result = new HospResponse(soapResult.Body.DoTransResult);
            // LogRecorder.BeginMonitor("kaishi");

            Console.WriteLine(result.FormatResult);

            // LogRecorder.EndMonitor();

            return result;
        }
    }
}
