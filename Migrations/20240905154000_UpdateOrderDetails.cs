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
                name: "FK_Menus_order_details_OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "Menus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                Tables: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderDetailsId",
                Tables: "Menus",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_order_details_OrderDetailsId",
                Tables: "Menus",
                column: "OrderDetailsId",
                principalTables: "order_details",
                principalColumn: "id");
        }
    }
}
