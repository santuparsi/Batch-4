using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Models;
using HandsOnAPIUsingEF.Repositories;
using Microsoft.AspNetCore.Cors;

namespace HandsOnAPIUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [Route("GetAll")]
        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }
        [Route("Get/{id}")]
        public Product Get(int id)
        {
            return _repository.GetProduct(id);
        }
        [Route("Add")]
        [HttpPost]
        public void Add(Product item)
        {
            _repository.Add(item);
        }
        [Route("Remove/{id}")]
        [HttpDelete]
        public void Remove(int id)
        {
            _repository.Delete(id);
        }
        [Route("Update")]
        [HttpPut]
        public void Update(Product item)
        {
            _repository.Update(item);
        }
    }
}
