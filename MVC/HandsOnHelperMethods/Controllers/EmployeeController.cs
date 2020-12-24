using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnHelperMethods.Models;
namespace HandsOnHelperMethods.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            if (ModelState.IsValid)
            {
                //Add Model details to db table
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
