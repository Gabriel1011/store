using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Store.Repositories;

namespace Store.Controllers
{
    
    public class HomeController :  Controller
    {
        private readonly ProductRepository _productRepository;

        public HomeController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Route("v1/products")] 
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.Get();
        }


        [Route("v1/products")] 
        [HttpPost]
        public void Post([FromBody] Product Product)
        {
            _productRepository.Post(Product);
        }
    }
}