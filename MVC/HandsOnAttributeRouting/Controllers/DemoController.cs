using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAttributeRouting.Controllers
{
    [Route("{controller}")]
    public class DemoController : Controller
    {
        [Route("GetAll")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Student/Details/{id}")]
        public IActionResult Details(int id)
        {
            return View();
        }
        [Route("Get/{name}")]
        public IActionResult Get(string name)
        {
            return View();
        }
    }
}
