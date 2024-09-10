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
                name: "FK_Categories_products_IdProduct",
                Tables: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoriesId",
                Tables: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories");

            migrationBuilder.RenameTables(
                name: "Categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_IdProduct",
                Tables: "Categories",
                newName: "IX_Categories_IdProduct");

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
                name: "FK_Categories_products_IdProduct",
                Tables: "Categories",
                column: "IdProduct",
                principalTables: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoriesId",
                Tables: "products",
                column: "CategoriesId",
                principalTables: "Categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_products_IdProduct",
                Tables: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoriesId",
                Tables: "products");

            migrationBuilder.DropTables(
                name: "companys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories");

            migrationBuilder.RenameTables(
                name: "Categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_IdProduct",
                Tables: "Categories",
                newName: "IX_Categories_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_products_IdProduct",
                Tables: "Categories",
                column: "IdProduct",
                principalTables: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoriesId",
                Tables: "products",
                column: "CategoriesId",
                principalTables: "Categories",
                principalColumn: "id");
        }
    }
}
