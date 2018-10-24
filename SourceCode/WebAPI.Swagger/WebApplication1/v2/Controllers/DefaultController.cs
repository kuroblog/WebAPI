using Microsoft.Web.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication1.v2.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/default")]
    public class DefaultController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IHttpActionResult> Get()
        {
            var result = Ok("v2");
            return await Task.FromResult(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<IHttpActionResult> Post([FromBody]Models.UserDto dto)
        {
            var result = Ok($"v2:created=>{JsonConvert.SerializeObject(dto)}");
            return await Task.FromResult(result);
        }
    }
}
