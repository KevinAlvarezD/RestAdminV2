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
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoriesId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_IdProduct",
                table: "Categories",
                newName: "IX_Categories_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "id");

            migrationBuilder.CreateTable(
                name: "companys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companys", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_products_IdProduct",
                table: "Categories",
                column: "IdProduct",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoriesId",
                table: "products",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_products_IdProduct",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoriesId",
                table: "products");

            migrationBuilder.DropTable(
                name: "companys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_IdProduct",
                table: "Categories",
                newName: "IX_Categories_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_products_IdProduct",
                table: "Categories",
                column: "IdProduct",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoriesId",
                table: "products",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "id");
        }
    }
}
