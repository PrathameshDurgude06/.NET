using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
namespace StudentManagementSystem.Repositories
{
    public class ConnectionContext : DbContext
    {
      
        public ConnectionContext(DbContextOptions<ConnectionContext>options):base(options)
        {
           
        }

        public DbSet<Student>Studentmang { get; set; }
    }
}
