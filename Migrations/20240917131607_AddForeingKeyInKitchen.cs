using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddForeingKeyInKitchen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "observations",
                table: "kitchen");

            migrationBuilder.RenameColumn(
                name: "table_id",
                table: "kitchen",
                newName: "order_id");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$Xd6ODWUdu./nvor35VqJBum79DfhHgAQ3PjrsmQwSksrZRoaDS/qK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$/gjaWWerCck8LHEAyktZUOXoTDfk3aUwqmyF4WsF2.rY05IqnyWUa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$NYEoX3yEJBoCj1oPg4.3OeOIfccKq68zttxZC7e/gt/.IUM2/N57.");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$msDY9PS9tSoXNsCoNCnPWeS1M9bho0K3D6MMwEbD.QZcHyovMvEpi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$MC4Y.h60i478zf7hGltvJOrNYrqIGYrVZcWWCI6UDc/SRi8VcbCSW");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$YZCfmVYbtUKJ8BvSfdmDiueM104jkvfuDnyIAsM31vP0OF217w03K");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$ajbMqiCNydofesDbjkra..82RY63f/vatAPkRjlt6HqGSqjnJV2oi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$UmuBXTJj349kvgRGf9paFe14HJhqLGCxcKZpQcHsXlXCZVkxk50BO");

            migrationBuilder.CreateIndex(
                name: "IX_kitchen_order_id",
                table: "kitchen",
                column: "order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_kitchen_orders_order_id",
                table: "kitchen",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kitchen_orders_order_id",
                table: "kitchen");

            migrationBuilder.DropIndex(
                name: "IX_kitchen_order_id",
                table: "kitchen");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "kitchen",
                newName: "table_id");

            migrationBuilder.AddColumn<string>(
                name: "observations",
                table: "kitchen",
                type: "varchar(155)",
                maxLength: 155,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$UACBfjkYjZMqcGsi9B4ep.wZVgyrreS5EKGXtHLcZrmGltxoPUh..");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$.WZ/zKn3BKfCD5ceCi9rBezMpWqWdjTjN1IB5Egx6JcPzBrhGHLHi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$p3xDFMrDG.AQ8hmupg/2H.7StZ4T6ND8GFVf0XO3HwrPNQDSEtuIG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$sF/ukyY9c31O4DZa1/zOOeD.Qu5PrTTt/coLXGnwHpNYhL/4ejCSS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$KXddNSE4pXecZt6HFaeoSOleGhRUcWyK2a5IlbjCnOQQhWLeJbaxu");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$86xXWNKpX1bl6Dwwbljlje6esn6NfedUAmtkIbnQbWGbqRGcK3tKC");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$C4iflfAJs09jTnTf22yXGuKms/uX7n5vkzO137SgxRJHAoZRpZuXW");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$gaY.lJYyAwBpGBlQ9QKaRuy8OfEXO.UdG4xKHGkeZG9I74enZreyi");
        }
    }
}
