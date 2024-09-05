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
                name: "FK_Category_products_IdProduct",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Category_CategoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "categorys");

            migrationBuilder.RenameIndex(
                name: "IX_Category_IdProduct",
                table: "categorys",
                newName: "IX_categorys_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categorys",
                table: "categorys",
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
                name: "FK_categorys_products_IdProduct",
                table: "categorys",
                column: "IdProduct",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categorys_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categorys",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categorys_products_IdProduct",
                table: "categorys");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categorys_CategoryId",
                table: "products");

            migrationBuilder.DropTable(
                name: "companys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categorys",
                table: "categorys");

            migrationBuilder.RenameTable(
                name: "categorys",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_categorys_IdProduct",
                table: "Category",
                newName: "IX_Category_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_products_IdProduct",
                table: "Category",
                column: "IdProduct",
                principalTable: "products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Category_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "id");
        }
    }
}
