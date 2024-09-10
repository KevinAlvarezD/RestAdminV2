using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddForeingKeyPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_payments_id_invoice",
                Tables: "payments",
                column: "id_invoice");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_invoices_id_invoice",
                Tables: "payments",
                column: "id_invoice",
                principalTables: "invoices",
                principalColumn: "id_invoice",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_invoices_id_invoice",
                Tables: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_id_invoice",
                Tables: "payments");
        }
    }
}
