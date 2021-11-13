using Microsoft.AspNetCore.Mvc;
using ProductsSampleModels.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsSampleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        static List<Product> _products = new List<Product> {
            new Product { Id = 1, Name = "Apple", Category = "Fruit", Price = 10 },
            new Product { Id = 2, Name = "Orange", Category = "Fruit", Price = 10 },
            new Product { Id = 3, Name = "Banana", Category = "Fruit", Price = 10 },
            new Product { Id = 4, Name = "Limon", Category = "Fruit", Price = 10 },
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
            newprod.Category = prod.Category;
            newprod.Price = prod.Price;
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _products.Remove(_products.Find(p => p.Id == id));
        }
    }
}
