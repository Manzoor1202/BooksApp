using BooksApp_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksApp_Temp.Data
{
    public class Books_RazorDbContext : DbContext
    {
        public Books_RazorDbContext(DbContextOptions<Books_RazorDbContext> options) : base(options)
        {
            
        }

         public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2},
                new Category { Id = 3, Name = "Comedy", DisplayOrder = 3 }
                );
        }
    }
}
