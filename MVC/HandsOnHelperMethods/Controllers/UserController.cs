using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnHelperMethods.Models;
namespace HandsOnHelperMethods.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Details(User item)
        {
            return View(item);
        }
    }
}
