using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using Flysh.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using HModels = Flysh.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace Flysh.Hosp.ProxyApi.Controllers.JHWR
{
    public class RegisterController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.CreateScope<IProxyService>();

        [Route("api/v1/register/cancel")]
        public ApiResult<RegisterCancelResponseModel> RegisterCancel(RegisterCancelRequestModel request)
        {
            var hisRequest = new HModels.Hosp3005Request
            {
                clinicNo = request.clinicNo,
                operCode = request.operCode
            };

            var result = proxyService.Do<HModels.Hosp3005Request, HModels.Hosp3005Response, RegisterCancelResponseModel>(
                hisRequest,
                (p) => new RegisterCancelResponseModel
                {
                    state = p.data == null ? 0 : p.data.state
                });

            return new ApiResult<RegisterCancelResponseModel>
            {
                Success = result.state == 0,
                ResultData = result.data,
                Status = new OperatorStatus
                {
                    ClientMessage = result.message
                }
            };
        }
    }
}
