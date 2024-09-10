using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddKitchenMenuRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menu_kitchen_KitchenId",
                table: "menu");

            migrationBuilder.RenameColumn(
                name: "KitchenId",
                table: "menu",
                newName: "kitchen_id");

            migrationBuilder.RenameIndex(
                name: "IX_menu_KitchenId",
                table: "menu",
                newName: "IX_menu_kitchen_id");

            migrationBuilder.AlterColumn<int>(
                name: "kitchen_id",
                table: "menu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_menu_kitchen_kitchen_id",
                table: "menu",
                column: "kitchen_id",
                principalTable: "kitchen",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_menu_kitchen_kitchen_id",
                table: "menu");

            migrationBuilder.RenameColumn(
                name: "kitchen_id",
                table: "menu",
                newName: "KitchenId");

            migrationBuilder.RenameIndex(
                name: "IX_menu_kitchen_id",
                table: "menu",
                newName: "IX_menu_KitchenId");

            migrationBuilder.AlterColumn<int>(
                name: "KitchenId",
                table: "menu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_menu_kitchen_KitchenId",
                table: "menu",
                column: "KitchenId",
                principalTable: "kitchen",
                principalColumn: "id");
        }
    }
}
