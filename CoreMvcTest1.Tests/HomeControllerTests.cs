using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreMVCTest1.Controllers;
using CoreMVCTest1.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace CoreMvcTest1.Tests
{
    [TestFixture]
    class HomeControllerTests
    {
        class ModelCompleteFakeRepository : IRepository
        {
            public IEnumerable<Product> Products { get; } = new Product[]
            {
                new Product {Name = "Kayak", Price = 5M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Socker ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            public void AddProduct(Product product)
            {
                
            }
        }
        [Test]
        public void IndexActionModelIsComplite()
        {
            var controller = new HomeController();
            controller.Repository = new ModelCompleteFakeRepository();
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            Assert.AreEqual(controller.Repository.Products.Count(), model.Count());
        }
    }
}
