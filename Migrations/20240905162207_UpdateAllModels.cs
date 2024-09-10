using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_Tables_Orders_OrderId",
                Tables: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_OrderId",
                Tables: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Orders_InvoiceIdInvoice",
                Tables: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderDetailsId",
                Tables: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_invoices_PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropColumn(
                name: "OrderId",
                Tables: "Tables");

            migrationBuilder.DropColumn(
                name: "InvoiceIdInvoice",
                Tables: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentIdPayment",
                Tables: "invoices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                Tables: "Tables",
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

            migrationBuilder.CreateIndex(
                name: "IX_Tables_OrderId",
                Tables: "Tables",
                column: "OrderId");

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
                name: "FK_Tables_Orders_OrderId",
                Tables: "Tables",
                column: "OrderId",
                principalTables: "Orders",
                principalColumn: "id");
        }
    }
}
