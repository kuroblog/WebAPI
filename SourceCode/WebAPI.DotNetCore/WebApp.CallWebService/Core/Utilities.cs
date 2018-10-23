
namespace WebApp.CallWebService.Core
{
    using JHWR;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Threading.Tasks;

    public static class Runner
    {
        public static async Task<TResult> Execute<TArgs, TResult>(Func<TArgs, Task<TResult>> func, TArgs args)
            where TArgs : class
            where TResult : class
        {
            try
            {
                return await func.Invoke(args);
            }
            catch (Exception ex)
            {
                return default(TResult);
            }
        }
    }

    public class DoTransArgs
    {
        public string TransCode { get; set; } = string.Empty;

        public string InJsonString { get; set; } = string.Empty;

        public DoTransArgs() { }

        public DoTransArgs(string transCode, string inJsonString)
        {
            TransCode = transCode;
            InJsonString = inJsonString;
        }

        public DoTransRequest RequestData
        {
            get { return new DoTransRequest(new DoTransRequestBody(TransCode, InJsonString)); }
        }
    }

    public class SvcResult
    {
        public string HisResult { get; private set; }

        public string JsonResult
        {
            get { return HisResult.Replace("\"[", "[").Replace("]\"", "]").Replace("\"{", "{").Replace("}\"", "}").Replace("\\\"", "\""); }
        }

        public SvcResult(string hisResult)
        {
            HisResult = hisResult;
        }
    }

    public interface IHisSvcProxyInterface
    {
        string Name { get; }

        Task<SvcResult> DoTrans(DoTransArgs args);
    }

    public class HisSocketProxy : IHisSvcProxyInterface
    {
        public string Name => "Socket";

        public Task<SvcResult> DoTrans(DoTransArgs args)
        {
            throw new NotImplementedException();
        }
    }

    public class HisWebSvcProxy : IHisSvcProxyInterface
    {
        public string Name => "WebService";

        private readonly string url = string.Empty;

        public HisWebSvcProxy(IOptions<HisOptions> hisOptions)
        {
            url = hisOptions.Value.Url;
        }

        private TSoap GenerateSoapClient<TSoap>()
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(url);

            var soapFactory = new ChannelFactory<TSoap>(binding, endpoint);
            var soapClient = soapFactory.CreateChannel();

            return soapClient;
        }

        public async Task<SvcResult> DoTrans(DoTransArgs args)
        {
            var soapClient = GenerateSoapClient<CallServiceSoapClientJHWRSoap>();
            var soapResult = await soapClient.DoTransAsync(args.RequestData);

            return await Task.FromResult(new SvcResult(soapResult.Body.DoTransResult));
        }
    }

    public sealed class ServiceFactory
    {
        public IHisSvcProxyInterface Instance { get; }

        public ServiceFactory(IEnumerable<IHisSvcProxyInterface> svcProxyArray, IOptions<HisOptions> hisOptions)
        {
            var hisMode = hisOptions.Value.Mode;
            Instance = svcProxyArray.FirstOrDefault(p => string.Compare(p.Name, hisMode) == 0);
        }
    }

    public class HisOptions
    {
        public string Mode { get; set; }

        public string Url { get; set; }
    }
}
