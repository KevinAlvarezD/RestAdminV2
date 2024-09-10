using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoriesOrderDetailsAndOrdered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                Tables: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_ordereds_id_order",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_customers_id_customer",
                Tables: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_Tables_id_Tables",
                Tables: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoriesId",
                Tables: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoriesId",
                Tables: "products");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderedId",
                Tables: "customers");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                Tables: "products");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                Tables: "customers");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_ordereds_id_order",
                Tables: "invoices",
                column: "id_order",
                principalTables: "ordereds",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_customers_id_customer",
                Tables: "ordereds",
                column: "id_customer",
                principalTables: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_Tables_id_Tables",
                Tables: "ordereds",
                column: "id_Tables",
                principalTables: "Tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoices_ordereds_id_order",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_customers_id_customer",
                Tables: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_Tables_id_Tables",
                Tables: "ordereds");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                Tables: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                Tables: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoriesId",
                Tables: "products",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_OrderedId",
                Tables: "customers",
                column: "OrderedId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                Tables: "customers",
                column: "OrderedId",
                principalTables: "ordereds",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_ordereds_id_order",
                Tables: "invoices",
                column: "id_order",
                principalTables: "ordereds",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_customers_id_customer",
                Tables: "ordereds",
                column: "id_customer",
                principalTables: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_Tables_id_Tables",
                Tables: "ordereds",
                column: "id_Tables",
                principalTables: "Tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoriesId",
                Tables: "products",
                column: "CategoriesId",
                principalTables: "Categories",
                principalColumn: "id");
        }
    }
}
