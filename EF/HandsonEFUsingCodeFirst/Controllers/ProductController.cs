using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonEFUsingCodeFirst.Repositories;
using HandsonEFUsingCodeFirst.Entities;
namespace HandsonEFUsingCodeFirst.Controllers
{
   
    public class ProductController : Controller
    {
        ProductRepository repository = new ProductRepository();
        [Route("Admin/GetAll")]
        public IActionResult Index()
        {
            List<Product> list = repository.GetProducts();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product item)
        {
            if(ModelState.IsValid)
            {
                repository.AddProduct(item);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [Route("Search/{id}")]
        public IActionResult Details(int id)
        {
            Product p = repository.GetProduct(id);
            return View(p);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product p = repository.GetProduct(id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(Product item)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateProduct(item);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(int id)
        {
            repository.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
