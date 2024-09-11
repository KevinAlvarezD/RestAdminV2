using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class updateAndResolveProblems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logo_url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    number = table.Column<int>(type: "int", nullable: false),
                    table_id = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<double>(type: "double", nullable: false),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "kitchen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    table_id = table.Column<int>(type: "int", nullable: false),
                    observations = table.Column<string>(type: "varchar(155)", maxLength: 155, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitchen", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pre_invoices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    number = table.Column<int>(type: "int", nullable: false),
                    table_id = table.Column<int>(type: "int", nullable: false),
                    observations = table.Column<string>(type: "varchar(155)", maxLength: 155, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    total = table.Column<double>(type: "double", nullable: false),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pre_invoices", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tables", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<double>(type: "double", nullable: false),
                    cost = table.Column<double>(type: "double", nullable: false),
                    image_url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tables_id = table.Column<int>(type: "int", nullable: false),
                    observations = table.Column<string>(type: "varchar(155)", maxLength: 155, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_orders_tables_tables_id",
                        column: x => x.tables_id,
                        principalTable: "tables",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "order_products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_order_products_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_products_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "address", "name", "phone" },
                values: new object[,]
                {
                    { 1, "Cra 50a 36 90", "Juliana Carvajal", "3242144893" },
                    { 2, "Cra 50a 23-17", "Alejandro Echavarria", "3004001077" }
                });

            migrationBuilder.InsertData(
                table: "company",
                columns: new[] { "id", "address", "email", "logo_url", "name", "nit", "phone" },
                values: new object[] { 1, "Cra 50 40 90", "administracionilforno@ilforno.com", "https://images.rappi.com/restaurants_logo/il-forno-logo1-1568819470999.png", "Il Forno", "49879684184", "3242144893" });

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
                columns: new[] { "Id", "category_id", "cost", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1, 1, 2100.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641772/j1sfl0ooipp2lfnaznbx.jpg", "Coca cola 400ml", 3500.0 },
                    { 2, 2, 9000.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641834/oeicuuwbem09deuyizwp.jpg", "Hamburguesa", 18000.0 },
                    { 3, 2, 12000.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641861/ix9ooxdajnvxijwq7bwv.jpg", "Pizza Peperoni", 22000.0 },
                    { 4, 1, 3500.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669032/zoc4meht10bhophsaz7z.jpg", "Postobon 1.5lt", 7000.0 },
                    { 5, 1, 2500.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669102/wtymyqe8qug10utjrhmj.jpg", "Michelada clasica", 5000.0 },
                    { 6, 1, 3500.0, "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669255/kg6sllhrux2qs3wogknz.jpg", "Michelada cereza", 7000.0 },
                    { 7, 4, 5000.0, "https://assets.unileversolutions.com/recipes-v2/219942.jpg", "Bruschetta", 12000.0 },
                    { 8, 4, 12000.0, "https://www.jocooks.com/wp-content/uploads/2022/04/tacos-al-pastor-feature-1.jpg", "Tacos al Pastor", 25000.0 },
                    { 9, 4, 3500.0, "https://www.elespectador.com/resizer/tyGJPN_YmWpagQFeXq_YYOxAKjY=/arc-anglerfish-arc2-prod-elespectador/public/2AVD5Z6Y2ZFWHETPQGCPLMNK4A.jpg", "Ceviche", 7000.0 },
                    { 10, 3, 3500.0, "https://escuelamundopastel.com/wp-content/uploads/2018/11/ORGANIZACI%C3%93N-DE-EVENTOS-10.png", "Cheesecake", 7000.0 },
                    { 11, 3, 3500.0, "https://badun.nestle.es/imgserver/v1/80/1290x742/ac5fa47c04dd-brownie-de-chocolate-negro.jpg", "Brownie", 6000.0 },
                    { 12, 3, 3500.0, "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/6BE1C69C-69FB-4957-96EA-D76159076661/Derivates/BA406212-38AE-4EA0-B4D5-591514C21C2D.jpg", "Tiramisu", 7000.0 }
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
                name: "IX_order_products_OrderId",
                table: "order_products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_order_products_ProductId",
                table: "order_products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_tables_id",
                table: "orders",
                column: "tables_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                table: "products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_role_id",
                table: "users",
                column: "role_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "kitchen");

            migrationBuilder.DropTable(
                name: "order_products");

            migrationBuilder.DropTable(
                name: "pre_invoices");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "tables");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
