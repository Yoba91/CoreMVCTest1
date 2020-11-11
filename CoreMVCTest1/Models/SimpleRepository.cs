using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTest1.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Socker ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };
            foreach (var item in initialItems)
            {
                AddProduct(item);
            }
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product item) => products.Add(item.Name, item);
    }
}
