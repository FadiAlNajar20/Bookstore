﻿// <auto-generated />
using Bookstore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookstore.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    partial class BookstoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "F. Scott Fitzgerald",
                            Genre = "Fiction",
                            Price = 10.99m,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Harper Lee",
                            Genre = "Fiction",
                            Price = 7.99m,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 3,
                            Author = "George Orwell",
                            Genre = "Dystopian",
                            Price = 8.99m,
                            Title = "1984"
                        },
                        new
                        {
                            Id = 4,
                            Author = "J.D. Salinger",
                            Genre = "Fiction",
                            Price = 9.99m,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            Id = 5,
                            Author = "J.R.R. Tolkien",
                            Genre = "Fantasy",
                            Price = 14.99m,
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Paulo Coelho",
                            Genre = "Adventure",
                            Price = 11.99m,
                            Title = "The Alchemist"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Aldous Huxley",
                            Genre = "Dystopian",
                            Price = 12.99m,
                            Title = "Brave New World"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Anne Frank",
                            Genre = "Biography",
                            Price = 6.99m,
                            Title = "The Diary of a Young Girl"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Markus Zusak",
                            Genre = "Historical Fiction",
                            Price = 13.99m,
                            Title = "The Book Thief"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Douglas Adams",
                            Genre = "Science Fiction",
                            Price = 10.49m,
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
