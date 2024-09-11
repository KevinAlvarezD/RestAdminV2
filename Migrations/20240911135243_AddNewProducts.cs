using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddNewProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "category_id",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Bebidas" },
                    { 2, "Comidas" },
                    { 3, "Postres" },
                    { 4, "Entradas" },
                    { 5, "Domicilios" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1,
                column: "category_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 2,
                column: "category_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 3,
                column: "category_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 4,
                column: "category_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 5,
                column: "category_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 6,
                column: "category_id",
                value: 1);

            migrationBuilder.InsertData(
                table: "tables",
                columns: new[] { "id", "name", "state" },
                values: new object[,]
                {
                    { 1, "Mesa 1", "Cocinando" },
                    { 2, "Mesa 2", "Por Facturar" },
                    { 3, "Mesa 3", "Ocupada" },
                    { 4, "Mesa 4", "Disponible" },
                    { 5, "Mesa 5", "Disponible" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_id", "cost", "image_url", "InvoiceId", "name", "OrderId", "PreInvoiceId", "price" },
                values: new object[,]
                {
                    { 7, 4, 5000.0, "https://assets.unileversolutions.com/recipes-v2/219942.jpg", null, "Bruschetta", null, null, 12000.0 },
                    { 8, 4, 12000.0, "https://www.jocooks.com/wp-content/uploads/2022/04/tacos-al-pastor-feature-1.jpg", null, "Tacos al Pastor", null, null, 25000.0 },
                    { 9, 4, 3500.0, "https://www.elespectador.com/resizer/tyGJPN_YmWpagQFeXq_YYOxAKjY=/arc-anglerfish-arc2-prod-elespectador/public/2AVD5Z6Y2ZFWHETPQGCPLMNK4A.jpg", null, "Ceviche", null, null, 7000.0 },
                    { 10, 3, 3500.0, "https://escuelamundopastel.com/wp-content/uploads/2018/11/ORGANIZACI%C3%93N-DE-EVENTOS-10.png", null, "Cheesecake", null, null, 7000.0 },
                    { 11, 3, 3500.0, "https://badun.nestle.es/imgserver/v1/80/1290x742/ac5fa47c04dd-brownie-de-chocolate-negro.jpg", null, "Brownie", null, null, 6000.0 },
                    { 12, 3, 3500.0, "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/6BE1C69C-69FB-4957-96EA-D76159076661/Derivates/BA406212-38AE-4EA0-B4D5-591514C21C2D.jpg", null, "Tiramisu", null, null, 7000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                table: "products",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_category_id",
                table: "products",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_category_id",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_category_id",
                table: "products");

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "category_id",
                table: "products");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "products",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1,
                column: "category",
                value: "Bebidas");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 2,
                column: "category",
                value: "Comida");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 3,
                column: "category",
                value: "Comida");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 4,
                column: "category",
                value: "Bebidas");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 5,
                column: "category",
                value: "Bebidas");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 6,
                column: "category",
                value: "Bebidas");
        }
    }
}
