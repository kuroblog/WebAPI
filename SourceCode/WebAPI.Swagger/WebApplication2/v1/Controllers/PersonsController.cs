
namespace WebApplication2.v1.Controllers
{
    using Microsoft.Web.Http;
    using Models;
    using Swashbuckle.Swagger.Annotations;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System;
    using Swashbuckle.Examples;

    /// <summary>
    /// persons api
    /// </summary>
    [ApiVersion("1.0")]
    [Route(VersionRouteSettings.PersonsApiVersion)]
    public class PersonsController : ApiController
    {
        private static IList<PersonEntity> persons { get; set; } = new List<PersonEntity>();

        /// <summary>
        /// get users
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>users</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<PersonEntity>))]
        [SwaggerResponseExample(HttpStatusCode.OK, typeof(PersonsExamples))]
        public async virtual Task<IHttpActionResult> Get([FromUri]int? id = null)
        {
            var result = persons?.ToList();
            if (id != null)
            {
                result = result?.Where(p => p.Id == id)?.ToList();
            }

            return await Task.FromResult(Ok(result));
        }

        /// <summary>
        /// post user
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>user</returns>
        [HttpPost]
        //[ResponseType(typeof(string))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PersonEntity))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(HttpResponseMessage))]
        public async virtual Task<IHttpActionResult> Post([FromBody]PersonDto dto)
        {
            if (dto == null)
            {
                return await Task.FromResult(BadRequest($"{nameof(PersonDto)} can not be empty."));
            }
            if (ModelState.IsValid == false)
            {
                return await Task.FromResult(BadRequest(ModelState));
            }

            persons.Add(new PersonEntity
            {
                Name = dto.name,
                Age = dto.age,
                Id = persons.Count
            });

            var result = Created("", persons.LastOrDefault());
            return await Task.FromResult(result);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class PersonsExamples : IExamplesProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object GetExamples()
        {
            return new List<PersonEntity> {
                new PersonEntity { Id = 0, Name = "user1", Age = 19 },
                new PersonEntity { Id = 1, Name = "user2" },
                new PersonEntity { Id = 2, Name = "user3", Age = 22 }
            };
        }
    }
}
