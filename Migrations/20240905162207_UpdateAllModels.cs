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
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_invoices_InvoiceIdInvoice",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_order_details_OrderDetailsId",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_tables_ordereds_OrderedId",
                table: "tables");

            migrationBuilder.DropIndex(
                name: "IX_tables_OrderedId",
                table: "tables");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_InvoiceIdInvoice",
                table: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_ordereds_OrderDetailsId",
                table: "ordereds");

            migrationBuilder.DropIndex(
                name: "IX_invoices_PaymentIdPayment",
                table: "invoices");

            migrationBuilder.DropColumn(
                name: "OrderedId",
                table: "tables");

            migrationBuilder.DropColumn(
                name: "InvoiceIdInvoice",
                table: "ordereds");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "ordereds");

            migrationBuilder.DropColumn(
                name: "PaymentIdPayment",
                table: "invoices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderedId",
                table: "tables",
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

            migrationBuilder.CreateIndex(
                name: "IX_tables_OrderedId",
                table: "tables",
                column: "OrderedId");

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
                name: "FK_tables_ordereds_OrderedId",
                table: "tables",
                column: "OrderedId",
                principalTable: "ordereds",
                principalColumn: "id");
        }
    }
}
