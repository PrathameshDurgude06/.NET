using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL
{

    public class CollectionContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root; password=root123;database=net";
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid);
                entity.Property(e => e.Pname).IsRequired();
                entity.Property(e => e.Qty).IsRequired();
                entity.Property(e => e.Price).IsRequired();
            });
            modelBuilder.Entity<Product>().ToTable("product");

        }
    }
}


