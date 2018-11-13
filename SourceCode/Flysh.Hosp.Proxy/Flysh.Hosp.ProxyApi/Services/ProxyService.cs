using System;

namespace Flysh.Hosp.ProxyApi
{
    public interface IProxyService
    {
        (int state, string message, TResult data) Do<THisRequest, THisResponse, TResult>(THisRequest request, Func<THisResponse, TResult> convert)
            where THisRequest : IHospProxyRequestModel, new()
            where THisResponse : IHospProxyResponseModel, new();
    }

    public class ProxyService : IProxyService
    {
        private readonly IHospProxyService hospProxyService;

        public ProxyService(IHospProxyService hospProxyService)
        {
            this.hospProxyService = hospProxyService;
        }

        public (int state, string message, TResult data) Do<THisRequest, THisResponse, TResult>(THisRequest request, Func<THisResponse, TResult> convert)
            where THisRequest : IHospProxyRequestModel, new()
            where THisResponse : IHospProxyResponseModel, new()
        {
            try
            {
                var hisResult = hospProxyService.Invoke<THisRequest, THisResponse>(request);

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
