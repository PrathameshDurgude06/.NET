using System.Collections.Generic;
using ProductsOnline.Models;

namespace ProductsOnline.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
