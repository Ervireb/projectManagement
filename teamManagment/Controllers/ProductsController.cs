using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using teamManagment.Models;

namespace teamManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Make 'products' readonly since it does not change after initialization
        private static readonly List<Product> products = new()
        {
            new() { Id = 1, Name = "Product1", Price = 10.0M },
            new() { Id = 2, Name = "Product2", Price = 20.0M }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
    }
}