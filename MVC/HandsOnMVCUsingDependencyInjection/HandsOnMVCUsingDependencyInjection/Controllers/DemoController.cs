using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingDependencyInjection.Services;
namespace HandsOnMVCUsingDependencyInjection.Controllers
{
    public class DemoController : Controller
    {
        public IProductService _service;
       
        public DemoController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }
    }
}
