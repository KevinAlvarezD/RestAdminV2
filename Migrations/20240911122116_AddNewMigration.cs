using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddNewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "role_id",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[,]
                {
                    { 1, "Cra 50a 36 90", "Juliana Carvajal", "3242144893" },
                    { 2, "Cra 50a 23-17", "Alejandro Echavarria", "3004001077" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category", "cost", "image_url", "InvoiceId", "name", "OrderId", "PreInvoiceId", "price" },
                values: new object[,]
                {
                    { 1, "Bebidas", 2100.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641772/j1sfl0ooipp2lfnaznbx.jpg", null, "Coca cola 400ml", null, null, 3500.0 },
                    { 2, "Comida", 9000.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641834/oeicuuwbem09deuyizwp.jpg", null, "Hamburguesa", null, null, 18000.0 },
                    { 3, "Comida", 12000.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641861/ix9ooxdajnvxijwq7bwv.jpg", null, "Pizza Peperoni", null, null, 22000.0 },
                    { 4, "Bebidas", 3500.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669032/zoc4meht10bhophsaz7z.jpg", null, "Postobon 1.5lt", null, null, 7000.0 },
                    { 5, "Bebidas", 2500.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669102/wtymyqe8qug10utjrhmj.jpg", null, "Michelada clasica", null, null, 5000.0 },
                    { 6, "Bebidas", 3500.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669255/kg6sllhrux2qs3wogknz.jpg", null, "Michelada cereza", null, null, 7000.0 }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Mesero" },
                    { 2, "Administrador" },
                    { 3, "Cajero" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "address", "email", "name", "password", "phone", "role_id" },
                values: new object[,]
                {
                    { 1, "Cra 50 40 90", "erik@elmejor.com", "Erik Uribe", "riwi1234", "3242144893", 1 },
                    { 2, "Cra 50a 36 90", "aechavarriaj@gmail.com", "Alejandro Echavarria", "Susana1901", "3004001077", 2 },
                    { 3, "Cra 59a 66 57", "alejomi192005@gmail.com", "Alejandro Castrillón", "21354", "333245884", 3 },
                    { 4, "Cra 45 67 89", "Alejandro@gmail.com", "Alejandro Londoño", "12345678", "3123456789", 2 },
                    { 5, "Cra 40 50 60", "kev@gmail.com", "Kevin Alvarez", "987654321", "3132145678", 2 },
                    { 6, "Cra 55 33 44", "laura.jimenez@restadmin.com", "Laura Jimenez", "laura2024", "3221234567", 3 },
                    { 7, "Cra 60 35 78", "carlos.mejia@restadmin.com", "Carlos Mejia", "admin2024", "3209876543", 1 },
                    { 8, "Cra 42 55 88", "diana.lopez@restadmin.com", "Diana Lopez", "cashier2024", "3111239876", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_role_id",
                table: "users",
                column: "role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_roles_role_id",
                table: "users",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_roles_role_id",
                table: "users");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropIndex(
                name: "IX_users_role_id",
                table: "users");

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "role_id",
                table: "users");
        }
    }
}
