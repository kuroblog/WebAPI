
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

    /// <summary>
    /// 
    /// </summary>
    public interface IHisProxyInterface
    {
        /// <summary>
        /// 
        /// </summary>
        HisInterfaceModes HisInterfaceMode { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<HisProxyResult> DoTransAsync<TData>(HisDoTransRequest<TData> data);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        HisProxyResult DoTrans<TData>(HisDoTransRequest<TData> data);
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class HisProxyFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public IHisProxyInterface Instance { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proxyArray"></param>
        /// <param name="hisOptions"></param>
        public HisProxyFactory(IEnumerable<IHisProxyInterface> proxyArray, IOptions<HisOptions> hisOptions)
        {
            var hisInterfaceMode = hisOptions.Value.Mode;
            Instance = proxyArray.FirstOrDefault(p => p.HisInterfaceMode == hisInterfaceMode);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisSocketProxy : IHisProxyInterface
    {
        /// <summary>
        /// 
        /// </summary>
        public HisInterfaceModes HisInterfaceMode => HisInterfaceModes.Socket;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<HisProxyResult> DoTransAsync<TData>(HisDoTransRequest<TData> data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public HisProxyResult DoTrans<TData>(HisDoTransRequest<TData> data)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class HisWebSvcProxy : IHisProxyInterface
    {
        /// <summary>
        /// 
        /// </summary>
        public HisInterfaceModes HisInterfaceMode => HisInterfaceModes.WebService;

        private readonly string url = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hisOptions"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<HisProxyResult> DoTransAsync<TData>(HisDoTransRequest<TData> data)
        {
            //var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();

            //var doTransRequest = data.GetRequestData<HisDoTransRequest<TData>, TData>();

            //var soapResult = await soapClient.DoTransAsync(doTransRequest);

            //return await Task.FromResult(new HisProxyResult(soapResult.Body.DoTransResult));

            return await Task.FromResult(DoTrans(data));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public HisProxyResult DoTrans<TData>(HisDoTransRequest<TData> data)
        {
            var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();

            var doTransRequest = data.GetRequestData<HisDoTransRequest<TData>, TData>();

            var soapResult = soapClient.DoTransAsync(doTransRequest).Result;

            return new HisProxyResult(soapResult.Body.DoTransResult);
        }
    }
}
