using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookstore.Migrations
{
    /// <inheritdoc />
    public partial class BookstoreAddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", 10.99m, "The Great Gatsby" },
                    { 2, "Harper Lee", "Fiction", 7.99m, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "Dystopian", 8.99m, "1984" },
                    { 4, "J.D. Salinger", "Fiction", 9.99m, "The Catcher in the Rye" },
                    { 5, "J.R.R. Tolkien", "Fantasy", 14.99m, "The Lord of the Rings" },
                    { 6, "Paulo Coelho", "Adventure", 11.99m, "The Alchemist" },
                    { 7, "Aldous Huxley", "Dystopian", 12.99m, "Brave New World" },
                    { 8, "Anne Frank", "Biography", 6.99m, "The Diary of a Young Girl" },
                    { 9, "Markus Zusak", "Historical Fiction", 13.99m, "The Book Thief" },
                    { 10, "Douglas Adams", "Science Fiction", 10.49m, "The Hitchhiker's Guide to the Galaxy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
