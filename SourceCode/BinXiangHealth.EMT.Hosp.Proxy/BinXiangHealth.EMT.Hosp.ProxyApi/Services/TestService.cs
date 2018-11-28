using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.ServiceModel;
using System.Xml;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Services
{
    public interface ITestService
    {
        Controllers.TestResponseDto GetRegisters(dynamic param);

        Controllers.TestResponseDto Test(string code, dynamic param);

        string Hello { get; }
    }

    public class TestService : ITestService
    {
        private readonly string url = string.Empty;

        public TestService(IOptions<HospProxySettings> proxySettings)
        {
            url = proxySettings.Value.Url;
        }

        public string Hello => $"{DateTime.Now.ToString()}: Hello.";

        public Controllers.TestResponseDto GetRegisters(dynamic param)
        {
            var result = new Controllers.TestResponseDto { code = "no code" };

            try
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

                var soapFactory = new ChannelFactory<AppServiceCommonSoap>(binding, endpoint);
                var soapClient = soapFactory.CreateChannel();

                string json = JsonConvert.SerializeObject(param);
                var soapResult = soapClient.GetRegisterListAsync(json).Result;

                result.result = soapResult;

                result.response = JsonConvert.DeserializeObject<dynamic>(soapResult.FormatHospResult());
                result.request = param;
            }
            catch (Exception ex)
            {
                result.error = JsonConvert.DeserializeObject<string[]>(ex.GetErrorMessages().ToJson());
            }

            return result;
        }

        public Controllers.TestResponseDto Test(string code, dynamic param)
        {
            var result = new Controllers.TestResponseDto { code = code };

            try
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

                var soapFactory = new ChannelFactory<AppServiceCommonSoap>(binding, endpoint);
                var soapClient = soapFactory.CreateChannel();

                string json = JsonConvert.SerializeObject(param);
                var soapResult = soapClient.DoTransAsync(code, json).Result;

                result.result = soapResult;

                result.response = JsonConvert.DeserializeObject<dynamic>(soapResult.FormatHospResult());
                result.request = param;
            }
            catch (Exception ex)
            {
                result.error = JsonConvert.DeserializeObject<string[]>(ex.GetErrorMessages().ToJson());
            }

            return result;
        }
    }
}
