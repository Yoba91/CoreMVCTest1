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
            public IEnumerable<Product> Products { get; set; }

            public void AddProduct(Product product)
            {

            }
        }
        [TestCase(5, 48, 19, 34)]
        [TestCase(25, 8, 1, 3)]
        public void IndexActionModelIsComplite(decimal price1, decimal price2, decimal price3, decimal price4)
        {
            var controller = new HomeController();
            controller.Repository = new ModelCompleteFakeRepository
            {
                Products = new Product[]
                {
                    new Product {Name = "Kayak", Price = price1},
                    new Product {Name = "Lifejacket", Price = price2},
                    new Product {Name = "Socker ball", Price = price3},
                    new Product {Name = "Corner flag", Price = price4},
                }
            };
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            Assert.AreEqual(controller.Repository.Products.Count(), model.Count());
        }
    }
}
