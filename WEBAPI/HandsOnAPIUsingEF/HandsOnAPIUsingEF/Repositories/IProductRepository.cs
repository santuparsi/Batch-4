using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Models;
namespace HandsOnAPIUsingEF.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void Add(Product item);
        void Delete(int id);
        void Update(Product item);

    }
}
