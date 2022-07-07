using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "The reclusive Kya Clark is suspected in the death of Chase Andrews", "https://images-na.ssl-images-amazon.com/images/I/51-uh7zesTL._SL300.jpg", 9.99m, "Where the Crawdads Sing" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Youth: Belly has an unforgettable summer with old friends and new experiences", "https://booklist.usatoday.com/covers/isbn/9781416968290.jpg", 19.99m, "The Summer I Turned Pretty" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Ryle Kincaid's relationship with Lily becomes complicated when a man from her past shows up", "https://images-na.ssl-images-amazon.com/images/I/51KZalxuryL._SL300.jpg", 3.99m, "It Ends With Us" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
