using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryOrderDetailsAndOrdered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_ordereds_id_order",
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_customers_id_customer",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_tables_id_table",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categorys_CategoryId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoryId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderedId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                table: "customers");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_ordereds_id_order",
                table: "invoices",
                column: "id_order",
                principalTable: "ordereds",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_customers_id_customer",
                table: "ordereds",
                column: "id_customer",
                principalTable: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_tables_id_table",
                table: "ordereds",
                column: "id_table",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoices_ordereds_id_order",
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_customers_id_customer",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_tables_id_table",
                table: "ordereds");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                table: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_OrderedId",
                table: "customers",
                column: "OrderedId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                table: "customers",
                column: "OrderedId",
                principalTable: "ordereds",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_ordereds_id_order",
                table: "invoices",
                column: "id_order",
                principalTable: "ordereds",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_customers_id_customer",
                table: "ordereds",
                column: "id_customer",
                principalTable: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_tables_id_table",
                table: "ordereds",
                column: "id_table",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categorys_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categorys",
                principalColumn: "id");
        }
    }
}
