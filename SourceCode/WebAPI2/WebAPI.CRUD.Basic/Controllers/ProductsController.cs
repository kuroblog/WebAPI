
namespace WebAPI.CRUD.Basic.Controllers
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using WebAPI.Models;

    public class ProductsController : ApiController
    {
        private static readonly IProductRepository repository = new ProductRepository();

        /// <summary>
        /// http://localhost:10031/api/products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// http://localhost:10031/api/products/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProduct(int id)
        {
            var item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return item;
        }

        /// <summary>
        /// http://localhost:10031/api/products?category=toys
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return repository.GetAll().Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }

        //public Product PostProduct(Product item)
        //{
        //    item = repository.Add(item);

        //    return item;
        //}

        /// <summary>
        /// http://localhost:10031/api/products
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public HttpResponseMessage PostProduct(Product item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);

            var uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        /// <summary>
        /// http://localhost:10031/api/products/1
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        public void PutProduct(int id, Product product)
        {
            product.Id = id;
            var isUpdated = repository.Update(product);
            if (!isUpdated)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// http://localhost:10031/api/products/1
        /// </summary>
        /// <param name="id"></param>
        public void DeleteProduct(int id)
        {
            var item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(id);
        }
    }
}
