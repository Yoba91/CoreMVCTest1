using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCTest1.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                var product = obj as Product;
                if (product.Name.Equals(Name) && product.Price.Equals(Price))
                    return true;
            }
            else
                return base.Equals(obj);
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
