using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVCTest1.Models;

namespace CoreMVCTest1.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = SimpleRepository.SharedRepository;
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products);
        [HttpGet]
        public IActionResult AddProduct() => View(new Product());
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            Repository.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}
