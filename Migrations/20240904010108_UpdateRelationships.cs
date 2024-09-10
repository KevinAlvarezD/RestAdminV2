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
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders");

            migrationBuilder.DropColumn(
                name: "pdf_file",
                Tables: "invoices");

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices",
                column: "id_order",
                principalTables: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders",
                column: "id_customer",
                principalTables: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders",
                column: "id_Tables",
                principalTables: "Tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders");

            migrationBuilder.AddColumn<byte[]>(
                name: "pdf_file",
                Tables: "invoices",
                type: "longblob",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_Orders_id_order",
                Tables: "invoices",
                column: "id_order",
                principalTables: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_customers_id_customer",
                Tables: "Orders",
                column: "id_customer",
                principalTables: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_id_Tables",
                Tables: "Orders",
                column: "id_Tables",
                principalTables: "Tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
