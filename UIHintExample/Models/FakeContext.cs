using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIHintExample.Models
{
    public class FakeContext
    {
        private static List<FakeProduct> ProductRepo;

        public FakeContext()
        {
            if (ProductRepo == null)
            {
                ProductRepo = new List<FakeProduct>
                {
                    new FakeProduct { Id = 1, Name = "Kek", Price = 1.25M, Description = "Çikolatalı kek" },
                    new FakeProduct { Id = 2, Name = "Makarna", Price = 4M, Description = "Kıvırcık makarna" },
                    new FakeProduct { Id = 3, Name = "Sucuk", Price = 35M, Description = "Kangal sucuk" }
                };
            }
        }

        public List<FakeProduct> Products
        {
            get
            {
                return ProductRepo;
            }
            set
            {
                ProductRepo = value;
            }
        }
    }

    public class FakeProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
    }
}