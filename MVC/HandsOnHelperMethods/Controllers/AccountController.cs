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
            if (ModelState.IsValid)
            {
                _repo.AddUser(user);
                return RedirectToAction("Login");
            }
            else
                return View();
        }
        public IActionResult Login()
        {
            return View();
        }
       
        public IActionResult Validate(Login item)
        {
            if (ModelState.IsValid)
            {
                User user = _repo.Validate(item);
                if (user != null)
                {
                    return RedirectToAction("Details", "User", user);
                }
                else
                {
                    ViewBag.errMsg = "Invalid Credentials";
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
            }
        }
    }
}
