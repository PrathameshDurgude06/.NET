using EcommerceProduct.Models;
using Microsoft.EntityFrameworkCore;


namespace EcommerceProduct.Repositories
{
    public class EStoreCollectionContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = @"server=localhost;port=3306;user=root;password=9311811@;database=ecommerce";
            optionsBuilder.UseMySQL(connstr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(
               entity =>
               {
                   entity.HasKey(e => e.Id);
                   entity.Property(e => e.Title).IsRequired();
                   entity.Property(e => e.Description);
                   entity.Property(e => e.UnitPrice).IsRequired();
                   entity.Property(e => e.ImageUrl);
                   entity.Property(e => e.Quantity).IsRequired();
               });
            modelBuilder.Entity<Product>().ToTable("Products");
        }

    }
}
