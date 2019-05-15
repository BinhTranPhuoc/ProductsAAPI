using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
            new Product {Id = 2, Name = "binhtran", Category = "Zenken", Price = 10},
            new Product {Id = 3, Name = "Binhtp", Category = "Tranaga", Price = 100},
            new Product {Id = 4, Name = "Zenken123", Category = "Zenken", Price = 1000}
        };

        // trả về tất cả các products
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        // trả về product theo id
        public IHttpActionResult GetProductById (int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
