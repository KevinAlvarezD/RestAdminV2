using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddTableKitchenItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kitchen_item",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    kitchen_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitchen_item", x => x.id);
                    table.ForeignKey(
                        name: "FK_kitchen_item_kitchen_kitchen_id",
                        column: x => x.kitchen_id,
                        principalTable: "kitchen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kitchen_item_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$ISaE.KqS6s8xna/mP7D8/eQs81MlViPp6Fwi1VysWqmu.5lFsx9EO");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$WnH/HOP81LxeK5lH0nfSIeUPuOJwCPVnycdpDRfLpkWTZCyOHfxAK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$3oIo8RNQYbn0h3EN5lYqsea3mye4pNCKYcb9hxhEtMiFq7nX.INdi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$DbhuhbnIZXnABN4fsbdbl.WUpBWB2hxZea9ktQHgAF8cnP0NKGLxK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$UK7ecb1g4Q1nJC85oBUDqOaCohoejLhzxUbGj.haBOQJziKUvJzX2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$jp2JQFLPqJYb0DidZpnnoO9uYqiWxc6iLEi3LRAqA9R.hLuNdPpVq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$BQH/D1FTuvqa7mMr2apSgua5qSmKOIuuNogx/UWNPa9JJqr93x.8.");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$FeyWfH281Ij7LpqLX60R4ebGBpX7DV4CrGy61bc6iL2BGPGXhuzMK");

            migrationBuilder.CreateIndex(
                name: "IX_kitchen_item_kitchen_id",
                table: "kitchen_item",
                column: "kitchen_id");

            migrationBuilder.CreateIndex(
                name: "IX_kitchen_item_product_id",
                table: "kitchen_item",
                column: "product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitchen_item");

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
        }
    }
}
