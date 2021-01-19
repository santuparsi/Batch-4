using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingJsonAndAjax.Models;
namespace HandsOnMVCUsingJsonAndAjax.Controllers
{
    public class ProductController : Controller
    {
        TrainingDBContext db = new TrainingDBContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            List<Product> list = db.Products.ToList();
            return Json(list);
        }
        public IActionResult Get(int id)
        {
            Product p = db.Products.SingleOrDefault(i => i.Pid == id);
            return Json(p);
                
        }
      
        public IActionResult Create(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
                
        }
    }
}
