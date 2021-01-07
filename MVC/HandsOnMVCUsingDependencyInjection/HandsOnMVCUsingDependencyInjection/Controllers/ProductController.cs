using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingDependencyInjection.Repositories;
namespace HandsOnMVCUsingDependencyInjection.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [Route("GetAll")]
        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }
        public IActionResult Details(int id)
        {
            return View(_repository.Get(id));
        }
    }
}
