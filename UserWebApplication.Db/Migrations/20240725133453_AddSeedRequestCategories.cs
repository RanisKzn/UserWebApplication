using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserWebApplication.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedRequestCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "request_categories",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Консультация" },
                    { 2, "Неполадка в системе" },
                    { 3, "Ошибка на сайте" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "request_categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "request_categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "request_categories",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
