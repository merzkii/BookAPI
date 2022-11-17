using BookAPI.Domain;
using BookAPI.Persistance.Config;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Persistance
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Author>Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author2Books> Author2Books { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new Author2BooksConfig());
            


        }
    }

}