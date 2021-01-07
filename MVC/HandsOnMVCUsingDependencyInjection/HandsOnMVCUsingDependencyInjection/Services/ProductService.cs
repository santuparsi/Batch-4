using HandsOnMVCUsingDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingDependencyInjection.Repositories;
namespace HandsOnMVCUsingDependencyInjection.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Add(Product item)
        {
            _repository.Add(item);
        }

        public Product Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
