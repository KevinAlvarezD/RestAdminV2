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
                name: "OrderId",
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
                Tables: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                Tables: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentIdPayment",
                Tables: "invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
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
                name: "IX_Tables_OrderId",
                Tables: "Tables",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_CategoriesId",
                Tables: "Menus",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderDetailsId",
                Tables: "Menus",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InvoiceIdInvoice",
                Tables: "Orders",
                column: "InvoiceIdInvoice");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailsId",
                Tables: "Orders",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_PaymentIdPayment",
                Tables: "invoices",
                column: "PaymentIdPayment");

            migrationBuilder.CreateIndex(
                name: "IX_customers_OrderId",
                Tables: "customers",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IdMenu",
                Tables: "Categories",
                column: "IdMenu");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_Orders_OrderId",
                Tables: "customers",
                column: "OrderId",
                principalTables: "Orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_payments_PaymentIdPayment",
                Tables: "invoices",
                column: "PaymentIdPayment",
                principalTables: "payments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_invoices_InvoiceIdInvoice",
                Tables: "Orders",
                column: "InvoiceIdInvoice",
                principalTables: "invoices",
                principalColumn: "id_invoice");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_order_details_OrderDetailsId",
                Tables: "Orders",
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
                name: "FK_Tables_Orders_OrderId",
                Tables: "Tables",
                column: "OrderId",
                principalTables: "Orders",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_Orders_OrderId",
                Tables: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_payments_PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_invoices_InvoiceIdInvoice",
                Tables: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_order_details_OrderDetailsId",
                Tables: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_order_details_OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Orders_OrderId",
                Tables: "Tables");

            migrationBuilder.DropTables(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Tables_OrderId",
                Tables: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Menus_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Orders_InvoiceIdInvoice",
                Tables: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderDetailsId",
                Tables: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_invoices_PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropIndex(
                name: "IX_customers_OrderId",
                Tables: "customers");

            migrationBuilder.DropColumn(
                name: "OrderId",
                Tables: "Tables");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "Menus");

            migrationBuilder.DropColumn(
                name: "InvoiceIdInvoice",
                Tables: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropColumn(
                name: "OrderId",
                Tables: "customers");
        }
    }
}
