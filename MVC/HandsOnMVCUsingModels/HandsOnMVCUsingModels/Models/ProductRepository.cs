using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingModels.Models
{
    public class ProductRepository : IProductRepository
    {
        public static List<Product> list = new List<Product>() { 
        new Product(){Pid=1,Pname="Keyboard",Price=1000,Stock=10},
         new Product(){Pid=2,Pname="Mouse",Price=700,Stock=10}
        };
    
        public void Add(Product item)
        {
            list.Add(item);
        }

        public Product Get(int id)
        {
            Product item = list.SingleOrDefault(i => i.Pid == id);
            return item;
        }

        public List<Product> GetAll()
        {
            return list;
        }
    }
}
