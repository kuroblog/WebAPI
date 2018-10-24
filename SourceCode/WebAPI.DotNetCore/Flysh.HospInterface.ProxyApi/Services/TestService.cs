
namespace Flysh.HospInterface.ProxyApi.Services
{
    using System;

    public interface ITestService
    {
        string Message { get; }
    }

    public class TestService : ITestService
    {
        public string Message => $"{DateTime.Now}: hello world!";
    }
}
