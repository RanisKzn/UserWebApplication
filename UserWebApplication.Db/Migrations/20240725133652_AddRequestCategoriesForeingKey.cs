using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserWebApplication.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddRequestCategoriesForeingKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "request_category_id",
                table: "requests",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_requests_request_category_id",
                table: "requests",
                column: "request_category_id");

            migrationBuilder.AddForeignKey(
                name: "fk_requests_request_categories_request_category_id",
                table: "requests",
                column: "request_category_id",
                principalTable: "request_categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_requests_request_categories_request_category_id",
                table: "requests");

            migrationBuilder.DropIndex(
                name: "ix_requests_request_category_id",
                table: "requests");

            migrationBuilder.DropColumn(
                name: "request_category_id",
                table: "requests");
        }
    }
}
