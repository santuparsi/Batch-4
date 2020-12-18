using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCCoreUsingControllerAndModelswithViews.Models
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> DataSource
        {
            get
            {
                return new List<Student>()
                {
                    new Student(){Sid=1,Sname="Rohan",Age=10,Class="III"},
                     new Student(){Sid=2,Sname="Jeson",Age=10,Class="III"},
                      new Student(){Sid=3,Sname="Karan",Age=10,Class="III"},
                       new Student(){Sid=4,Sname="Monica",Age=10,Class="III"},
                        new Student(){Sid=5,Sname="Joy",Age=10,Class="III"},
                         new Student(){Sid=6,Sname="TIm",Age=10,Class="III"},
                };
            }
        }
        public Student GetStudent(int id)
        {
            return DataSource.SingleOrDefault(i => i.Sid == id);
        }

        public List<Student> GetStudents()
        {
            return DataSource;
        }
    }
}
