using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.CRUD.Basic.Models;

namespace WebAPI.CRUD.Basic.Controllers
{
    public class TestsController : ApiController
    {
        // GET: api/Tests
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tests/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tests
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tests/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tests/5
        public void Delete(int id)
        {
        }

        #region Action Results in Web API 2

        /* references
         * https://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/action-results
         */

        [Route("~/api/test/s1")]
        public HttpResponseMessage GetS1()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content = new StringContent("S1", Encoding.Unicode);
            response.Headers.CacheControl = new CacheControlHeaderValue { MaxAge = TimeSpan.FromMinutes(20) };

            return response;
        }

        [Route("~/api/test/s2")]
        public HttpResponseMessage GetS2()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, "String");
            response.Content = new StringContent("S2", Encoding.Unicode);
            response.Headers.CacheControl = new CacheControlHeaderValue { MaxAge = TimeSpan.FromMinutes(20) };

            return response;
        }

        [Route("~/api/test/s3")]
        public HttpResponseMessage GetS3()
        {
            var products = new ProductRepository().GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, products);
        }

        [Route("~/api/test/s4")]
        public IHttpActionResult GetS4()
        {
            var products = new ProductRepository().GetAll();
            if (products == null || products.Count() <= 0)
            {
                return NotFound();
            }

            return Ok(products);
        }

        [Route("~/api/test/s4/{id}")]
        public IHttpActionResult GetS4(int id)
        {
            var product = new ProductRepository().Get(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [Route("~/api/test/s5")]
        public IHttpActionResult GetS5()
        {
            return new TextResult("Hello", Request);
        }
        #endregion
    }

    public class TextResult : IHttpActionResult
    {
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(new HttpResponseMessage
            {
                Content = new StringContent(_value, Encoding.Unicode),
                RequestMessage = _request
            });
        }

        private string _value;

        private HttpRequestMessage _request;

        public TextResult(string value, HttpRequestMessage request)
        {
            _value = value;
            _request = request;
        }
    }
}
