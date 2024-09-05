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
                name: "FK_categorys_products_IdProduct",
                table: "categorys");

            migrationBuilder.DropIndex(
                name: "IX_categorys_IdProduct",
                table: "categorys");

            migrationBuilder.DropColumn(
                name: "IdProduct",
                table: "categorys");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdProduct",
                table: "categorys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categorys_IdProduct",
                table: "categorys",
                column: "IdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_categorys_products_IdProduct",
                table: "categorys",
                column: "IdProduct",
                principalTable: "products",
                principalColumn: "id");
        }
    }
}
