using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingViewModel.Models.ViewModel;
using HandsOnMVCUsingViewModel.Models;
namespace HandsOnMVCUsingViewModel.Controllers
{
    public class StudetnController : Controller
    {
        [Route("Details")]
        public IActionResult Index()
        {
            Student s = new Student() { Sid = 1, Sname = "Rohan", Class = "II" };
            StudentAddress sd = new StudentAddress() { Sid = 1, State = "Karanataka", Town = "Banglore", Street = "BTM" };
            StudentAddressVM vm = new StudentAddressVM()
            {
                Student = s,
                StudentAddress = sd,
                Email = "rohan@gmail.com",
                Mobile = "948340433"
            };
            return View(vm);
        }
    }
}
