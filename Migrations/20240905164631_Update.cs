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
                Tables: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_IdProduct",
                Tables: "Categories");

            migrationBuilder.DropColumn(
                name: "IdProduct",
                Tables: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdProduct",
                Tables: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IdProduct",
                Tables: "Categories",
                column: "IdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_products_IdProduct",
                Tables: "Categories",
                column: "IdProduct",
                principalTables: "products",
                principalColumn: "id");
        }
    }
}
