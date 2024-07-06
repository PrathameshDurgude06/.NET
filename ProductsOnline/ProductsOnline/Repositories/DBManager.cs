using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProductsOnline.Models;

namespace ProductsOnline.Repositories
{
    public class DBManager : IDBManager
    {
        private readonly EStoreCollectionContext _context;

        public DBManager(EStoreCollectionContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product product = _context.Products.Find(id);
            _context.Products.Remove(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
