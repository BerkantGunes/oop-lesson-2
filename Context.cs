using Microsoft.EntityFrameworkCore;
using Project_OOP.Entity;

namespace Project_OOP.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GUNESBERKANT\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;encrypt=false;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
