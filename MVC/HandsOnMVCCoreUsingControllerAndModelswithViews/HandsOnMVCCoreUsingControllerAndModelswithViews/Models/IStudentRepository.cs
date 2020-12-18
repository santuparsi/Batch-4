using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCCoreUsingControllerAndModelswithViews.Models
{
    interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
    }
}
