using EF_Core_Code_First_Books_Project.Entities.Concret;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_Books_Project.DataAccess.SqlDbContext
{
    public class BookManagmentDbContex : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Localhost;Initial Catalog=MyBooksDB;Integrated Security = true; TrustServerCertificate=True;");
        }

        public DbSet<Author> Authors {  get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
    }
}
