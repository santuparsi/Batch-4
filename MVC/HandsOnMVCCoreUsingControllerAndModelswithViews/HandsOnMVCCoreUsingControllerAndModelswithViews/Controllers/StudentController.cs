using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCCoreUsingControllerAndModelswithViews.Models;
namespace HandsOnMVCCoreUsingControllerAndModelswithViews.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository repository = new StudentRepository();
        public JsonResult GetAllStudents()
        {
            List<Student> list = repository.GetStudents();
            return Json(list);
        }
        public JsonResult GetStudent(int id)
        {
            Student s = repository.GetStudent(id);
            return Json(s);
        }
    }
}
