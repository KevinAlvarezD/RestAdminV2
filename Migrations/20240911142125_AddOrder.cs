using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_orders_OrderId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OrderId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_orders_product_id",
                table: "orders",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_table_id",
                table: "orders",
                column: "table_id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_product_id",
                table: "orders",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_tables_table_id",
                table: "orders",
                column: "table_id",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_product_id",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_table_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_product_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_table_id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 2,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 3,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 4,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 5,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 6,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 7,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 8,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 9,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 10,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 11,
                column: "OrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 12,
                column: "OrderId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_products_OrderId",
                table: "products",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_orders_OrderId",
                table: "products",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "id");
        }
    }
}
