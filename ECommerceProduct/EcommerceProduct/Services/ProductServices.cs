using EcommerceProduct.Models;
using EcommerceProduct.Repositories;

namespace EcommerceProduct.Services
{
    public class ProductServices : IProductService
    {
        public List<Product> GetProducts()
        {
            using (var context = new EStoreCollectionContext())
            {
                var products = from prod in
                        context.Products
                               select prod;
                return products.ToList<Product>();
            }

        }

        public List<Product> GetProductById(int id)
        {
            List<Product> products = DBManager.GetProductById(id);
            return products;
        }

        /*
        public bool Insert(Product product)
        {
            return true;
        }

        public bool Update(Product product)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }*/
    }
}
