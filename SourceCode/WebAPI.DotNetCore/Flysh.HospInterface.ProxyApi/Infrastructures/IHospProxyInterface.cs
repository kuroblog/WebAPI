
namespace Flysh.HospInterface.ProxyApi.Infrastructures
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHospProxyInterface
    {
        /// <summary>
        /// 
        /// </summary>
        HospProxyModes HisInterfaceMode { get; }

        //Task<HospResponse> DoTransAsync<TData>(HospRequest<TData> data);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        HospResponse Invoke<TData>(HospRequest<TData> data);
    }
}
