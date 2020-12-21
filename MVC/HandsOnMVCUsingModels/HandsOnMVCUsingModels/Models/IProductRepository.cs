using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingModels.Models
{
    interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product item);
    }
}
