using EcommerceProduct.Models;

namespace EcommerceProduct.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();

        List<Product> GetProductById(int id);

        //bool insert(Product product);

        //bool update(Product product);

        //bool delete(int id); 
    }
}
