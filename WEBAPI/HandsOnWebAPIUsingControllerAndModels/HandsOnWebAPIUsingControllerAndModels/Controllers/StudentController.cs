using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnWebAPIUsingControllerAndModels.Repositories;
using HandsOnWebAPIUsingControllerAndModels.Models;
namespace HandsOnWebAPIUsingControllerAndModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentRepository _repo;
        public StudentController(IStudentRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Student> GetStudents()
        {
            return _repo.GetAll();
        }
        [HttpGet]
        [Route("Get/{id}")]
        public Student GetStudent(int id)
        {
            return _repo.Get(id);
        }
        [HttpPost ]
        public void AddStudent(Student item)
        {
            //Add Student details heer
        }
        [HttpPut]
        public void UpdateStudent(Student item)
        {
            //Update studetn code here
        }
        [HttpDelete]
        public void RemoveStudent(int id)
        {
            //Delete code here
        }

    }
}
