using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriesAndCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                Tables: "Tables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                Tables: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                Tables: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceIdInvoice",
                Tables: "ordereds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                Tables: "ordereds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentIdPayment",
                Tables: "invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                Tables: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTables(
                name: "Categories",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMenu = Tables.Column<int>(type: "int", nullable: true)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_Categories", x => x.id);
                    Tables.ForeignKey(
                        name: "FK_Categories_Menus_IdMenu",
                        column: x => x.IdMenu,
                        principalTables: "Menus",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_OrderedId",
                Tables: "Tables",
                column: "OrderedId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_CategoriesId",
                Tables: "Menus",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderDetailsId",
                Tables: "Menus",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ordereds_InvoiceIdInvoice",
                Tables: "ordereds",
                column: "InvoiceIdInvoice");

            migrationBuilder.CreateIndex(
                name: "IX_ordereds_OrderDetailsId",
                Tables: "ordereds",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_PaymentIdPayment",
                Tables: "invoices",
                column: "PaymentIdPayment");

            migrationBuilder.CreateIndex(
                name: "IX_customers_OrderedId",
                Tables: "customers",
                column: "OrderedId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IdMenu",
                Tables: "Categories",
                column: "IdMenu");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                Tables: "customers",
                column: "OrderedId",
                principalTables: "ordereds",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_payments_PaymentIdPayment",
                Tables: "invoices",
                column: "PaymentIdPayment",
                principalTables: "payments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_invoices_InvoiceIdInvoice",
                Tables: "ordereds",
                column: "InvoiceIdInvoice",
                principalTables: "invoices",
                principalColumn: "id_invoice");

            migrationBuilder.AddForeignKey(
                name: "FK_ordereds_order_details_OrderDetailsId",
                Tables: "ordereds",
                column: "OrderDetailsId",
                principalTables: "order_details",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus",
                column: "CategoriesId",
                principalTables: "Categories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_order_details_OrderDetailsId",
                Tables: "Menus",
                column: "OrderDetailsId",
                principalTables: "order_details",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_ordereds_OrderedId",
                Tables: "Tables",
                column: "OrderedId",
                principalTables: "ordereds",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_ordereds_OrderedId",
                Tables: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_payments_PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_invoices_InvoiceIdInvoice",
                Tables: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_order_details_OrderDetailsId",
                Tables: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_order_details_OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_ordereds_OrderedId",
                Tables: "Tables");

            migrationBuilder.DropTables(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Tables_OrderedId",
                Tables: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Menus_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_InvoiceIdInvoice",
                Tables: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_OrderDetailsId",
                Tables: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_invoices_PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderedId",
                Tables: "customers");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                Tables: "Tables");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropColumn(
                name: "InvoiceIdInvoice",
                Tables: "ordereds");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "ordereds");

            migrationBuilder.DropColumn(
                name: "PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                Tables: "customers");
        }
    }
}
