using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModels.Models;
namespace HandsOnMVCUsingModels.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository _repo = new ProductRepository();
        //Get All the Product
        public IActionResult Index()
        {
            List<Product> list = _repo.GetAll();
            return View(list);
        }
        //Get Product Using Id
        public IActionResult Details(int id)
        {
            Product item = _repo.Get(id);
            if(item!=null)
            return View(item);
            else
            {
                ViewBag.errMsg = "Invalid Id";
                return View();
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product item)
        {
            _repo.Add(item);
            return RedirectToAction("Index");
        }
    }
}
