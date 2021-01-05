using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonEFUsingCodeFirst.Entities;
namespace HandsonEFUsingCodeFirst.Repositories
{
    interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product item);
        void UpdateProduct(Product item);
        void DeleteProduct(int id);
    }
}
