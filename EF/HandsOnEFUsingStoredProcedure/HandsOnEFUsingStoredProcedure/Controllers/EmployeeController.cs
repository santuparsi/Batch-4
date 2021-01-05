using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEFUsingStoredProcedure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
namespace HandsOnEFUsingStoredProcedure.Controllers
{
    public class EmployeeController : Controller
    {
        TrainingDBContext db = new TrainingDBContext();
       
        [Route("GetAll")]
        public IActionResult Index()
        {
            List<Employee> list = db.Employees.FromSqlRaw("sp_getemp").ToList();
            return View(list);
        }
        [Route("Get/{id}")]
        public IActionResult Details(int id)
        {
            List<Employee> list = db.Employees.FromSqlRaw("GetEmpById @eid", new[] {
               new SqlParameter("@eid",id)
            }).ToList();
            Employee e = list.SingleOrDefault(i => i.Eid == id);
            return View(e);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            db.Database.ExecuteSqlRaw("sp_add_emp @eid,@ename,@sal,@joindate",
                new[]
                {
                    new SqlParameter("@eid",item.Eid),
                    new SqlParameter("@ename",item.Ename),
                    new SqlParameter("@sal",item.Salary),
                    new SqlParameter("@joindate",item.JoinDate),
                });
            return RedirectToAction("Index");
        }
    }
}
