using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_products_InvoiceId",
                table: "products",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_products_PreInvoiceId",
                table: "products",
                column: "PreInvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_products_InvoiceId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_PreInvoiceId",
                table: "products");
        }
    }
}
