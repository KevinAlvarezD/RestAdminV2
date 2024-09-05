using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryAndCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                table: "tables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceIdInvoice",
                table: "ordereds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "ordereds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentIdPayment",
                table: "invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                table: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdProduct = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                    table.ForeignKey(
                        name: "FK_Category_products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "products",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tables_OrderedId",
                table: "tables",
                column: "OrderedId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_OrderDetailsId",
                table: "products",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ordereds_InvoiceIdInvoice",
                table: "ordereds",
                column: "InvoiceIdInvoice");

            migrationBuilder.CreateIndex(
                name: "IX_ordereds_OrderDetailsId",
                table: "ordereds",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_PaymentIdPayment",
                table: "invoices",
                column: "PaymentIdPayment");

            migrationBuilder.CreateIndex(
                name: "IX_customers_OrderedId",
                table: "customers",
                column: "OrderedId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_IdProduct",
                table: "Category",
                column: "IdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                table: "customers",
                column: "OrderedId",
                principalTable: "ordereds",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_payments_PaymentIdPayment",
                table: "invoices",
                column: "PaymentIdPayment",
                principalTable: "payments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_invoices_InvoiceIdInvoice",
                table: "ordereds",
                column: "InvoiceIdInvoice",
                principalTable: "invoices",
                principalColumn: "id_invoice");

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_order_details_OrderDetailsId",
                table: "ordereds",
                column: "OrderDetailsId",
                principalTable: "order_details",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Category_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_order_details_OrderDetailsId",
                table: "products",
                column: "OrderDetailsId",
                principalTable: "order_details",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tables_ordereds_OrderedId",
                table: "tables",
                column: "OrderedId",
                principalTable: "ordereds",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_payments_PaymentIdPayment",
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_invoices_InvoiceIdInvoice",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_order_details_OrderDetailsId",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Category_CategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_order_details_OrderDetailsId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_tables_ordereds_OrderedId",
                table: "tables");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_tables_OrderedId",
                table: "tables");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoryId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OrderDetailsId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_InvoiceIdInvoice",
                table: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_OrderDetailsId",
                table: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_invoices_PaymentIdPayment",
                table: "invoices");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderedId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                table: "tables");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "InvoiceIdInvoice",
                table: "ordereds");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "ordereds");

            migrationBuilder.DropColumn(
                name: "PaymentIdPayment",
                table: "invoices");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                table: "customers");
        }
    }
}
