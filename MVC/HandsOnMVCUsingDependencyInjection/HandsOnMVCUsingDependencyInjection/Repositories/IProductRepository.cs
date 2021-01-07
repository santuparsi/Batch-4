using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingDependencyInjection.Models;
namespace HandsOnMVCUsingDependencyInjection.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product item);
    }
}
