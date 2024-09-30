using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .Property(b => b.Price)
            .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99M, Genre = "Fiction" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 7.99M, Genre = "Fiction" },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", Price = 8.99M, Genre = "Dystopian" },
                new Book { Id = 4, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 9.99M, Genre = "Fiction" },
                new Book { Id = 5, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Price = 14.99M, Genre = "Fantasy" },
                new Book { Id = 6, Title = "The Alchemist", Author = "Paulo Coelho", Price = 11.99M, Genre = "Adventure" },
                new Book { Id = 7, Title = "Brave New World", Author = "Aldous Huxley", Price = 12.99M, Genre = "Dystopian" },
                new Book { Id = 8, Title = "The Diary of a Young Girl", Author = "Anne Frank", Price = 6.99M, Genre = "Biography" },
                new Book { Id = 9, Title = "The Book Thief", Author = "Markus Zusak", Price = 13.99M, Genre = "Historical Fiction" },
                new Book { Id = 10, Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", Price = 10.49M, Genre = "Science Fiction" }
            );
        }

    }
}
