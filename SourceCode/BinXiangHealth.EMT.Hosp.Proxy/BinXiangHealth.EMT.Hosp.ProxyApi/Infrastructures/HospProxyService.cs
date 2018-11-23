using Agebull.Common.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Reflection;
using System.ServiceModel;
using System.Xml;

namespace BinXiangHealth.EMT.Hosp.ProxyApi
{
    public interface IHospProxyService
    {
        TResponse DoTrans<TRequest, TResponse>(TRequest request)
            where TRequest : IHospProxyRequestModel, new()
            where TResponse : IHospProxyResponseModel, new();

        (string result, string json, string error) Test(string code, string json);
    }

    public class HospWebProxyService : IHospProxyService
    {
        private readonly string url = string.Empty;

        public HospWebProxyService(IOptions<HospProxySettings> proxySettings)
        {
            url = proxySettings.Value.Url;
        }

        public TResponse DoTrans<TRequest, TResponse>(TRequest request)
            where TRequest : IHospProxyRequestModel, new()
            where TResponse : IHospProxyResponseModel, new()
        {
            try
            {
                using (MonitorScope.CreateScope(MethodBase.GetCurrentMethod().Name))
                {
                    var soapRequest = request.ConvertToHospRequest();
                    LogRecorder.MonitorTrace(new { doCode = soapRequest.code, doRequest = soapRequest.json }.ToJson());

                    var soapClient = GenerateSoapClient<AppServiceCommonSoap>();
                    var soapResult = soapClient.DoTransAsync(soapRequest.code, soapRequest.json).Result;

                    LogRecorder.MonitorTrace(new { doCode = soapRequest.code, doResponse = soapResult }.ToJson());

                    var result = JsonConvert.DeserializeObject<TResponse>(soapResult.FormatHospResult());
                    LogRecorder.MonitorTrace(new { doCode = soapRequest.code, doFormatResult = soapResult }.ToJson());

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public (string result, string json, string error) Test(string code, string json)
        {
            try
            {
                var soapClient = GenerateSoapClient<AppServiceCommonSoap>();
                var soapResult = soapClient.DoTransAsync(code, json).Result;

                var result = soapResult.FormatHospResult();

                return (soapResult, result, string.Empty);
            }
            catch (Exception ex)
            {
                return (string.Empty, string.Empty, ex.GetErrorMessages().ToJson());
            }
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
