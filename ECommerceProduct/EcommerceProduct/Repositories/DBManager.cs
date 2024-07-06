using EcommerceProduct.Models;

namespace EcommerceProduct.Repositories
{
    public static class DBManager
    {
        public static List<Product> GetProducts()
        {
            using(var context = new EStoreCollectionContext())
            {
                var products = from prod in
                        context.Products
                               select prod;
                return products.ToList<Product>();
            }
            
        }

        public static List<Product> GetProductById(int id)
        {
            using (var context = new EStoreCollectionContext())
            {
                var product = from prod in context.Products where prod.Id == id
                              select prod;
                return product.ToList<Product>();
            }
        }





    }
}
