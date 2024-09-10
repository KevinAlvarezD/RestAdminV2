using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_products_IdProduct",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_IdProduct",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IdProduct",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdProduct",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IdProduct",
                table: "Categories",
                column: "IdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_products_IdProduct",
                table: "Categories",
                column: "IdProduct",
                principalTable: "products",
                principalColumn: "id");
        }
    }
}
