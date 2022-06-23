using Microsoft.EntityFrameworkCore;
using RazorPageKurs.Models;

namespace RazorPageKurs.Data
{
    //Iin Program.cs am IOC regristriert
    public sealed class BookDbContext : DbContext
    {
        /// <summary>
        /// Optionale Einstellungen u.a ConnectionString oder weiter EF Core Settings
        /// </summary>
        /// <param name="options"></param>
        public BookDbContext(DbContextOptions<BookDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}
