using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnModelBinding.Models;
namespace HandsOnModelBinding.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User item)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            if (uname == "admin" && pwd == "12345")
            {
                ViewBag.errmsg = "Valid User";
                return View();
            }
            else
            {
                ViewBag.errmsg = "Invalid User";
                return View();
            }
        }
    }
}
