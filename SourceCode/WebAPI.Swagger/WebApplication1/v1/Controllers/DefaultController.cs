using Microsoft.Web.Http;
using Newtonsoft.Json;
using Swashbuckle.Examples;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;

namespace WebApplication1.v1.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/default")]
    public class DefaultController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //[ResponseType(typeof(string))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(string))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
        [SwaggerResponse(HttpStatusCode.ServiceUnavailable, Type = typeof(string))]
        public async Task<IHttpActionResult> Get()
        {
            var result = Ok("v1");
            return await Task.FromResult(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        //[ResponseType(typeof(string))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(CountryExamples))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(string))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(string))]
        [SwaggerResponse(HttpStatusCode.ServiceUnavailable, Type = typeof(string))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(string))]
        public async Task<IHttpActionResult> Post([FromBody]Models.UserDto dto)
        {
            if (ModelState.IsValid == false)
            {
                return await Task.FromResult(BadRequest(JsonConvert.SerializeObject(ModelState.Values.SelectMany(p => p.Errors))));
            }

            var result = Ok($"v1:created=>{JsonConvert.SerializeObject(dto)}");
            return await Task.FromResult(result);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CountryExamples : IExamplesProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object GetExamples()
        {
            return "user created.";
        }
    }
}
