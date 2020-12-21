using HandsOnMVCCoreUsingControllerAndModelswithViews.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCCoreUsingControllerAndModelswithViews.Controllers
{
    public class Student1Controller : Controller
    {
        StudentRepository repository = new StudentRepository();
        public IActionResult GetStudentName(int id)
        {
            string name = repository.DataSource.SingleOrDefault(i => i.Sid == id).Sname;
            //set name in ViewData
            ViewData["un"] = name;
            return View();
        }
        public IActionResult GetStudent(int id)
        {
            Student s = repository.DataSource.SingleOrDefault(i => i.Sid == id);
            ViewData["item"] = s;
            return View();
        }
        public IActionResult GetAll()
        {
            List<Student> list = repository.DataSource;
            ViewData["list"] = list;
            return View();
        }
        public IActionResult Sum(int a,int b)
        {
            int c = a + b;
            ViewBag.Result = c;
            return View();
        }

    }
}
