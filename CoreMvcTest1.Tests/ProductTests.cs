using System;
using System.Collections.Generic;
using System.Text;
using CoreMVCTest1.Models;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit;
using NUnit.Framework;

namespace CoreMvcTest1.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void CanChangeProductName()
        {
            var p = new Product { Name = "Test", Price = 100M };
            p.Name = "New Name";
            Assert.AreEqual("New Name", p.Name);
        }
        [Test]
        public void CanChangeProductPrice()
        {
            var p = new Product { Name = "Test", Price = 100M };
            p.Price = 200M;
            Assert.AreEqual(200M, p.Price);
        }
    }
}
