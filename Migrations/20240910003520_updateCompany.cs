using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class updateCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companys",
                Tables: "companys");

            migrationBuilder.RenameTables(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTables(
                name: "companys",
                newName: "company");

            migrationBuilder.RenameColumn(
                name: "image_url",
                Tables: "company",
                newName: "logo_url");

            migrationBuilder.AddColumn<string>(
                name: "email",
                Tables: "company",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nit",
                Tables: "company",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "phone",
                Tables: "company",
                type: "varchar(25)",
                maxLength: 25,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                Tables: "categories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_company",
                Tables: "company",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                Tables: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_company",
                Tables: "company");

            migrationBuilder.DropColumn(
                name: "email",
                Tables: "company");

            migrationBuilder.DropColumn(
                name: "nit",
                Tables: "company");

            migrationBuilder.DropColumn(
                name: "phone",
                Tables: "company");

            migrationBuilder.RenameTables(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTables(
                name: "company",
                newName: "companys");

            migrationBuilder.RenameColumn(
                name: "logo_url",
                Tables: "companys",
                newName: "image_url");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                Tables: "Categories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_companys",
                Tables: "companys",
                column: "id");
        }
    }
}
