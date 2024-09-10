using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoriesOrderDetailsAndOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_Orders_OrderId",
                Tables: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderId",
                Tables: "customers");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropColumn(
                name: "OrderId",
                Tables: "customers");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices",
                column: "id_order",
                principalTables: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders",
                column: "id_customer",
                principalTables: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders",
                column: "id_Tables",
                principalTables: "Tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                Tables: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                Tables: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_CategoriesId",
                Tables: "Menus",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_OrderId",
                Tables: "customers",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_Orders_OrderId",
                Tables: "customers",
                column: "OrderId",
                principalTables: "Orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices",
                column: "id_order",
                principalTables: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders",
                column: "id_customer",
                principalTables: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders",
                column: "id_Tables",
                principalTables: "Tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus",
                column: "CategoriesId",
                principalTables: "Categories",
                principalColumn: "id");
        }
    }
}
