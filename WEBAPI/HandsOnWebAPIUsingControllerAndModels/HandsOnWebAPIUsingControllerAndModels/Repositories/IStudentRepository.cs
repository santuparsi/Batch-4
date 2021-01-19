using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnWebAPIUsingControllerAndModels.Models;
namespace HandsOnWebAPIUsingControllerAndModels.Repositories
{
   public interface IStudentRepository
    {
        List<Student> GetAll();
        Student Get(int id);

    }
}
