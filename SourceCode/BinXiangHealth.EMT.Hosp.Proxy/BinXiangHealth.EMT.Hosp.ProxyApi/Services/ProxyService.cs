using System;

namespace BinXiangHealth.EMT.Hosp.ProxyApi
{
    public interface IProxyService
    {
        (int state, string message, TResult data) Do<THospRequest, THospResponse, TResult>(THospRequest request, Func<THospResponse, TResult> convert)
            where THospRequest : IHospProxyRequestModel, new()
            where THospResponse : IHospProxyResponseModel, new();
    }

    public class ProxyService : IProxyService
    {
        private readonly IHospProxyService hospProxyService;

        public ProxyService(IHospProxyService hospProxyService)
        {
            this.hospProxyService = hospProxyService;
        }

        public (int state, string message, TResult data) Do<THospRequest, THospResponse, TResult>(THospRequest request, Func<THospResponse, TResult> convert)
            where THospRequest : IHospProxyRequestModel, new()
            where THospResponse : IHospProxyResponseModel, new()
        {
            try
            {
                var hisResult = hospProxyService.Invoke<THospRequest, THospResponse>(request);

                if (hisResult == null)
                {
                    return (-1, "no his data.", default(TResult));
                }
                else if (hisResult.IsSuccess == false)
                {
                    return (hisResult.GetResponseCode(), hisResult.GetResponseMessage(), default(TResult));
                }

                return (0, string.Empty, convert.Invoke(hisResult));
            }
            catch (Exception ex)
            {
                var error = ex.GetErrorMessages().ToJson();

                return (-9, ex.GetErrorMessages().ToJson(), default(TResult));
            }
        }
    }
}
