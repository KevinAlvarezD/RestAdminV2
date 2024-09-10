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
                name: "FK_ordereds_invoices_InvoiceIdInvoice",
                Tables: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_order_details_OrderDetailsId",
                Tables: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_ordereds_OrderedId",
                Tables: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_OrderedId",
                Tables: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_InvoiceIdInvoice",
                Tables: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_OrderDetailsId",
                Tables: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_invoices_PaymentIdPayment",
                Tables: "invoices");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                Tables: "Tables");

            migrationBuilder.DropColumn(
                name: "InvoiceIdInvoice",
                Tables: "ordereds");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                Tables: "ordereds");

            migrationBuilder.DropColumn(
                name: "PaymentIdPayment",
                Tables: "invoices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                Tables: "Tables",
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

            migrationBuilder.CreateIndex(
                name: "IX_Tables_OrderedId",
                Tables: "Tables",
                column: "OrderedId");

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
                name: "FK_Tables_ordereds_OrderedId",
                Tables: "Tables",
                column: "OrderedId",
                principalTables: "ordereds",
                principalColumn: "id");
        }
    }
}
