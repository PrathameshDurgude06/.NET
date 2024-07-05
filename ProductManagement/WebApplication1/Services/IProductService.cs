using BOL;
namespace SL
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Insert(Product dept);
        void Update(Product dept);
        void Delete(int id);
    }
}
