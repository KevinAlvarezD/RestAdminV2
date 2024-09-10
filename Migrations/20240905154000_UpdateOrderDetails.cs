using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_order_details_OrderDetailsId",
                Tables: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OrderDetailsId",
                Tables: "products");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                Tables: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_OrderDetailsId",
                Tables: "products",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_order_details_OrderDetailsId",
                Tables: "products",
                column: "OrderDetailsId",
                principalTables: "order_details",
                principalColumn: "id");
        }
    }
}
