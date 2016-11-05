
namespace WebAPI.Client.Basic
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    class Program
    {
        private static HttpClient client = new HttpClient();

        private static void ShowProduct(Product product)
        {
            Console.WriteLine($"Name:{product.Name}\tPrice:{product.Price}\tCategory:{product.Category}");
        }

        private static async Task<Uri> CreateProductAsync(Product product)
        {
            var response = await client.PostAsJsonAsync("api/products", product);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        private static async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var response = await client.GetAsync("api/products");
            response.EnsureSuccessStatusCode();

            var products = await response.Content.ReadAsAsync<IEnumerable<Product>>();

            return products;
        }

        private static async Task<Product> GetProductAsync(string path)
        {
            Product product = null;
            var response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }

            return product;
        }

        private static async Task<Product> UpdateProductAsync(Product product)
        {
            var response = await client.PutAsJsonAsync($"api/products/{product.Id}", product);
            response.EnsureSuccessStatusCode();

            product = await response.Content.ReadAsAsync<Product>();

            return product;
        }

        private static async Task<HttpStatusCode> DeleteProductAsync(int id)
        {
            var response = await client.DeleteAsync($"api/products/{id}");
            return response.StatusCode;
        }

        private static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost:10031/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var products = await GetProductsAsync();
                products.ToList().ForEach(p => ShowProduct(p));

                var product = new Product { Name = "test1", Price = 7.77M, Category = "Test" };

                var url = await CreateProductAsync(product);
                Console.WriteLine($"Created at {url}");

                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                Console.WriteLine("Updating price ...");
                product.Price = 80M;
                await UpdateProductAsync(product);

                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                var statusCode = await DeleteProductAsync(product.Id);
                Console.WriteLine($"Deleted (HTTP Status = {statusCode})");
            }
            catch (Exception ex)
            {
                var errors = new List<Tuple<int, string, string>>();
                var tmp = ex;
                var index = 0;
                do
                {
                    errors.Add(Tuple.Create(++index, ex.GetType().Name, ex.Message.Replace(Environment.NewLine, string.Empty)));
                    ex = tmp.InnerException == null ? null : ex.InnerException;
                } while (ex != null);

                if (errors.Count > 0)
                {
                    Console.WriteLine($"执行完成，发生以下错误：{Environment.NewLine}");
                    errors.ForEach(p => Console.WriteLine($"{p.Item1.ToString().PadLeft(2, '0')}）异常类型:{p.Item2};异常信息:{p.Item3}{Environment.NewLine}"));
                }
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            RunAsync().Wait();
        }
    }
}
