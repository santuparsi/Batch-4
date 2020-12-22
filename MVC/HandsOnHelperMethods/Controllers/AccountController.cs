using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnHelperMethods.Models;
namespace HandsOnHelperMethods.Controllers
{
    public class AccountController : Controller
    {
        UserRepository _repo = new UserRepository();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            _repo.AddUser(user);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
       
        public IActionResult Validate(string uname,string pwd)
        {
            User user = _repo.Validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details", "User", user);
            }
            else
            {
                ViewBag.errMsg = "Invalid Credentials";
                return View("Login");
            }
        }
    }
}
