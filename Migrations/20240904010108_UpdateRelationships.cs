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
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_customers_id_customer",
                table: "ordereds");

            migrationBuilder.DropForeignKey(
                name: "FK_ordereds_tables_id_table",
                table: "ordereds");

            migrationBuilder.DropColumn(
                name: "pdf_file",
                table: "invoices");

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

            migrationBuilder.AddColumn<byte[]>(
                name: "pdf_file",
                table: "invoices",
                type: "longblob",
                nullable: true);

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
    }
}
