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
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Menus_IdMenu",
                Tables: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_IdMenu",
                Tables: "Categories");

            migrationBuilder.DropColumn(
                name: "IdMenu",
                Tables: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMenu",
                Tables: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IdMenu",
                Tables: "Categories",
                column: "IdMenu");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Menus_IdMenu",
                Tables: "Categories",
                column: "IdMenu",
                principalTables: "Menus",
                principalColumn: "id");
        }
    }
}
