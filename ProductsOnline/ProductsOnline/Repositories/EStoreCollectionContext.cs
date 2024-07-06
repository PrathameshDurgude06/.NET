using Microsoft.EntityFrameworkCore;
using ProductsOnline.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProductsOnline.Repositories
{
    public class EStoreCollectionContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString =@"server=localhost;port=3306;user=root; password=; database=ECommerceDB";
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}
