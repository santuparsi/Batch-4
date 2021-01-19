using HandsOnWebAPIUsingControllerAndModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HandsOnWebAPIUsingControllerAndModels.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> DataSource
        {
            get
            {
                return new List<Student>()
                {
                    new Student(){Sid=1,Sname="Karan",Age=10},
                    new Student(){Sid=2,Sname="Charan",Age=10}
                };
            }
        }
        public Student Get(int id)
        {
            return DataSource.SingleOrDefault(item => item.Sid ==id);
        }

        public List<Student> GetAll()
        {
            return DataSource;
        }
    }
}
