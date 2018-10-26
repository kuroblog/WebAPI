
namespace Flysh.HospInterface.ProxyApi.Services
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public interface ITestService
    {
        /// <summary>
        /// 
        /// </summary>
        string Message { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TestService : ITestService
    {
        /// <summary>
        /// 
        /// </summary>
        public string Message => $"{DateTime.Now}: hello world!";
    }
}
