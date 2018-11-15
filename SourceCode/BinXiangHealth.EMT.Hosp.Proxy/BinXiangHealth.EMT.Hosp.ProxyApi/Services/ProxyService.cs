using Agebull.Common.Logging;
using System;
using System.Reflection;

namespace BinXiangHealth.EMT.Hosp.ProxyApi
{
    public interface IProxyService
    {
        (int state, string message, TResponse data) DoTrans<THospRequest, THospResponse, TRequest, TResponse>(TRequest request, Func<TRequest, THospRequest> requestParser, Func<THospResponse, TResponse> hospResponseParser)
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

        public (int state, string message, TResponse data) DoTrans<THospRequest, THospResponse, TRequest, TResponse>(TRequest request, Func<TRequest, THospRequest> requestParser, Func<THospResponse, TResponse> hospResponseParser)
            where THospRequest : IHospProxyRequestModel, new()
            where THospResponse : IHospProxyResponseModel, new()
        {
            return Do(
                MethodBase.GetCurrentMethod().Name,
                () =>
                {
                    LogRecorder.MonitorTrace(request.ToJson());
                    var hospRequest = requestParser(request);

                    var hospResult = hospProxyService.DoTrans<THospRequest, THospResponse>(hospRequest);

                    (int state, string message, TResponse data) response;
                    if (hospResult == null)
                    {
                        response = (-1, "hosp result is null.", default(TResponse));
                    }
                    else if (hospResult.IsSuccess == false)
                    {
                        response = (hospResult.GetResponseCode(), hospResult.GetResponseMessage(), default(TResponse));
                    }

                    response = (0, string.Empty, hospResponseParser.Invoke(hospResult));

                    LogRecorder.MonitorTrace(new
                    {
                        response.state,
                        response.message,
                        response.data
                    }.ToJson());

                    return response;
                });
        }

        private (int state, string message, TResult data) Do<TResult>(string methodName, Func<(int state, string message, TResult data)> func)
        {
            try
            {
                using (MonitorScope.CreateScope(methodName))
                {
                    return func.Invoke();
                }
            }
            catch (Exception ex)
            {
                var error = ex.GetErrorMessages().ToJson();

                LogRecorder.Error(error);

                return (-9, ex.GetErrorMessages().ToJson(), default(TResult));
            }
        }
    }
}
