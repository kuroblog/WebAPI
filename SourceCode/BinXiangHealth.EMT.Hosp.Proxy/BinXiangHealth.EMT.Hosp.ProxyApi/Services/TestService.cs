using System;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Services
{
    public interface ITestService
    {
        (string result, string json, string error) Test(string code, string json);

        string Hello { get; }
    }

    public class TestService : ITestService
    {
        private readonly IHospProxyService hospProxyService;

        public TestService(IHospProxyService hospProxyService)
        {
            this.hospProxyService = hospProxyService;
        }

        public string Hello => $"{DateTime.Now.ToString()}: Hello.";

        public (string result, string json, string error) Test(string code, string json)
        {
            return hospProxyService.Test(code, json);
        }
    }
}
