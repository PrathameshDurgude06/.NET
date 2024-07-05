using BOL;
using DAL;
namespace SL
{
    public class ProductService : IProductService
    {
        DBManager dbManager=new DBManager();
        public ProductService() { }

        public void Delete(int id)
        {
            dbManager.Delete(id);
        }

        public List<Product> GetAll()
        {
            List<Product> products = dbManager.GetAll();
            return products;
        }

        public Product GetById(int id)
        {
            Product product = dbManager.GetById(id);
            return product;
        }

        public void Insert(Product prod)
        {
            dbManager.Insert(prod);
        }

        public void Update(Product prod)
        {
            dbManager.Update(prod);
        }
    }
}
