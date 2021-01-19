using HandsOnAPIUsingEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIUsingEF.Repositories
{
    public class ProductRepositroy : IProductRepository
    {
        private TrainingDBContext db;
        public ProductRepositroy()
        {
            db = new TrainingDBContext();
        }

        public void Add(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Product p=db.Products.Find(id);
            db.Products.Remove(p);
            db.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            Product p = db.Products.Find(id);
            return p;
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public void Update(Product item)
        {
            db.Products.Update(item);
            db.SaveChanges();
        }
    }
}
