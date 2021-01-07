using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonEFUsingCodeFirst.Entities;
using HandsonEFUsingCodeFirst.DBAccess;
namespace HandsonEFUsingCodeFirst.Repositories
{
    public class ProductRepository : IProductRepository
    {
        MyContext db = null;
          public ProductRepository(MyContext context)
        {
            db = context;
        }
           
        public void AddProduct(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product p = db.Products.Find(id);
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

        public void UpdateProduct(Product item)
        {
            db.Products.Update(item);
            db.SaveChanges();
        }
    }
}
