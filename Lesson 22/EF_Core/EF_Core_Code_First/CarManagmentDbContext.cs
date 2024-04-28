using Microsoft.EntityFrameworkCore;

namespace EF_Core_Code_First
{
    public class CarManagmentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Localhost;Initial Catalog=\"CarManagmentDB\";Integrated Security = true;");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Accounting> Accountings { get; set; }
    }
}
