using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "pdf_file",
                Tables: "invoices");

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

            migrationBuilder.AddColumn<byte[]>(
                name: "pdf_file",
                Tables: "invoices",
                type: "longblob",
                nullable: true);

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
    }
}
