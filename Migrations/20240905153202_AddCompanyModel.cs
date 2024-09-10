using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Menus_IdMenu",
                Tables: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories");

            migrationBuilder.RenameTables(
                name: "Categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_IdMenu",
                Tables: "Categories",
                newName: "IX_Categories_IdMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories",
                column: "id");

            migrationBuilder.CreateTables(
                name: "companys",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_url = Tables.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_companys", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Menus_IdMenu",
                Tables: "Categories",
                column: "IdMenu",
                principalTables: "Menus",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus",
                column: "CategoriesId",
                principalTables: "Categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Menus_IdMenu",
                Tables: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus");

            migrationBuilder.DropTables(
                name: "companys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories");

            migrationBuilder.RenameTables(
                name: "Categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_IdMenu",
                Tables: "Categories",
                newName: "IX_Categories_IdMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Menus_IdMenu",
                Tables: "Categories",
                column: "IdMenu",
                principalTables: "Menus",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Categories_CategoriesId",
                Tables: "Menus",
                column: "CategoriesId",
                principalTables: "Categories",
                principalColumn: "id");
        }
    }
}
