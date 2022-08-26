using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Services.ProductAPI.Migrations
{
    public partial class NewProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Test 1", "Test 1", "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg", "Test 1", 15.0 },
                    { 2, "Test 2", "Test 2", "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg", "Test 2", 13.99 },
                    { 3, "Test 3", "Test 3", "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg", "Test 3", 10.99 },
                    { 4, "Test 4 ", "Test 4", "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg", "Test 4", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
