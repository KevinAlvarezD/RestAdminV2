using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_products_orders_order_id",
                table: "order_products");

            migrationBuilder.DropForeignKey(
                name: "FK_order_products_products_product_id",
                table: "order_products");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_table_id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "observations",
                table: "order_products");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "order_products");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "table_id",
                table: "orders",
                newName: "tables_id");

            migrationBuilder.RenameIndex(
                name: "IX_orders_table_id",
                table: "orders",
                newName: "IX_orders_tables_id");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "order_products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "order_products",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_order_products_product_id",
                table: "order_products",
                newName: "IX_order_products_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_order_products_order_id",
                table: "order_products",
                newName: "IX_order_products_OrderId");

            migrationBuilder.AddColumn<string>(
                name: "observations",
                table: "orders",
                type: "varchar(155)",
                maxLength: 155,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_order_products_orders_OrderId",
                table: "order_products",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_products_products_ProductId",
                table: "order_products",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_tables_tables_id",
                table: "orders",
                column: "tables_id",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_products_orders_OrderId",
                table: "order_products");

            migrationBuilder.DropForeignKey(
                name: "FK_order_products_products_ProductId",
                table: "order_products");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_tables_tables_id",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "observations",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "tables_id",
                table: "orders",
                newName: "table_id");

            migrationBuilder.RenameIndex(
                name: "IX_orders_tables_id",
                table: "orders",
                newName: "IX_orders_table_id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "order_products",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "order_products",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "IX_order_products_ProductId",
                table: "order_products",
                newName: "IX_order_products_product_id");

            migrationBuilder.RenameIndex(
                name: "IX_order_products_OrderId",
                table: "order_products",
                newName: "IX_order_products_order_id");

            migrationBuilder.AddColumn<string>(
                name: "observations",
                table: "order_products",
                type: "varchar(155)",
                maxLength: 155,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "order_products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_order_products_orders_order_id",
                table: "order_products",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_products_products_product_id",
                table: "order_products",
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
    }
}
