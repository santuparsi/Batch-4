using HandsOnMVCUsingDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingDependencyInjection.Repositories
{
    public class ProductRepository : IProductRepository
    {
        TrainingDBContext db = null;
        public ProductRepository()
        {
            db = new TrainingDBContext();
        }
        public void Add(Product item)
        {
            db.Add(item);
            db.SaveChanges();
        }

        public Product Get(int id)
        {
           return db.Products.SingleOrDefault(p => p.Pid == id);
           
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
    }
}
