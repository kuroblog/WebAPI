
namespace WebAPI.CRUD.Basic.Models
{
    using System;
    using System.Collections.Generic;
    using WebAPI.Models;

    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        void Remove(int id);
        bool Update(Product item);
    }

    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int nextId = 1;

        public ProductRepository()
        {
            Add(new Product { Name = "Tomato soup", Category = "Groceries", Price = 1.39M });
            Add(new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id.Equals(id));
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            item.Id = nextId++;
            products.Add(item);

            return item;
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id.Equals(id));
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            var index = products.FindIndex(p => p.Id.Equals(item.Id));
            if (index < 0)
            {
                return false;
            }

            products.RemoveAt(index);
            products.Add(item);

            return true;
        }
    }
}
