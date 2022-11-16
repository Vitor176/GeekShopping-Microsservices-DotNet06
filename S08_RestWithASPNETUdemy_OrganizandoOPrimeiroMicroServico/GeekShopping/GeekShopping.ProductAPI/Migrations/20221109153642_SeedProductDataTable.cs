using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Camiseta", "is simply dummy text of the printing and typesetting industry. n printer", "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg", "Name", 69m },
                    { 3L, "Camiseta", "is simply dummy text of the printing and typesetting industry. n printer", "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg", "Name", 69m },
                    { 4L, "Camiseta", "is simply dummy text of the printing and typesetting industry. n printer", "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg", "Name", 69m },
                    { 5L, "Camiseta", "is simply dummy text of the printing and typesetting industry. n printer", "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg", "Name", 69m },
                    { 6L, "Camiseta", "is simply dummy text of the printing and typesetting industry. n printer", "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg", "Name", 69m },
                    { 7L, "Camiseta", "is simply dummy text of the printing and typesetting industry. n printer", "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg", "Name", 69m },
                    { 8L, "Camiseta", "is simply dummy text of the printing and typesetting industry. n printer", "https://m.media-amazon.com/images/I/51yoMkiWWHL._AC_SX522_.jpg", "Name", 69m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 8L);
        }
    }
}
