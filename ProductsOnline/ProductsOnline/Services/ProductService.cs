using System.Collections.Generic;
using ProductsOnline.Models;
using ProductsOnline.Repositories;

namespace ProductsOnline.Services
{
    public class ProductService : IProductService
    {
        private readonly IDBManager _dbManager;

        public ProductService(IDBManager dbManager)
        {
            _dbManager = dbManager;
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbManager.GetAll();
        }

        public Product GetById(int id)
        {
            return _dbManager.GetById(id);
        }

        public void Insert(Product product)
        {
            _dbManager.Insert(product);
            _dbManager.Save();
        }

        public void Update(Product product)
        {
            _dbManager.Update(product);
            _dbManager.Save();
        }

        public void Delete(int id)
        {
            _dbManager.Delete(id);
            _dbManager.Save();
        }
    }
}
