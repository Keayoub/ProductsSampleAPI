using Microsoft.AspNetCore.Mvc;
using ProductsSampleAPI.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsSampleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        static List<Product> _products = new List<Product> {
            new Product { Id = 1, Name = "Apple", Description = "Apple", Quantity = 10 },
            new Product { Id = 2, Name = "Orange", Description = "Orange", Quantity = 10 },
            new Product { Id = 3, Name = "Banana", Description = "Banana", Quantity = 10 },
            new Product { Id = 4, Name = "Limon", Description = "Limon", Quantity = 10 },
        };

        // GET: /<Products>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product prod)
        {
            _products.Add(prod);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product prod)
        {
            var newprod = _products.Find(p => p.Id == prod.Id);
            newprod.Name = prod.Name;
            newprod.Description = prod.Description;
            newprod.Quantity = prod.Quantity;
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _products.Remove(_products.Find(p => p.Id == id));
        }
    }
}
