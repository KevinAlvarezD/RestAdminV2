using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTables(
                name: "customers",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_customers", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTables(
                name: "Users",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = Tables.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = Tables.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    schedule = Tables.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_Users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTables(
                name: "payments",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_invoice = Tables.Column<int>(type: "int", nullable: false),
                    date_payment = Tables.Column<DateTime>(type: "datetime(6)", nullable: false),
                    amount = Tables.Column<double>(type: "double", nullable: false),
                    payment_method = Tables.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_payments", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTables(
                name: "Menus",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image_url = Tables.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = Tables.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = Tables.Column<double>(type: "double", nullable: false)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_Menus", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTables(
                name: "Tables",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tables_number = Tables.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    capacity = Tables.Column<int>(type: "int", nullable: false)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_Tables", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTables(
                name: "ordereds",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = Tables.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_customer = Tables.Column<int>(type: "int", nullable: false),
                    id_Tables = Tables.Column<int>(type: "int", nullable: false),
                    Users = Tables.Column<int>(type: "int", nullable: false)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_ordereds", x => x.id);
                    Tables.ForeignKey(
                        name: "FK_ordereds_customers_id_customer",
                        column: x => x.id_customer,
                        principalTables: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    Tables.ForeignKey(
                        name: "FK_ordereds_Tables_id_Tables",
                        column: x => x.id_Tables,
                        principalTables: "Tables",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTables(
                name: "invoices",
                columns: Tables => new
                {
                    id_invoice = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_order = Tables.Column<int>(type: "int", nullable: false),
                    date_invoice = Tables.Column<DateTime>(type: "datetime(6)", nullable: false),
                    total = Tables.Column<double>(type: "double", nullable: false)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_invoices", x => x.id_invoice);
                    Tables.ForeignKey(
                        name: "FK_invoices_ordereds_id_order",
                        column: x => x.id_order,
                        principalTables: "ordereds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_id_order",
                Tables: "invoices",
                column: "id_order");

            migrationBuilder.CreateIndex(
                name: "IX_ordereds_id_customer",
                Tables: "ordereds",
                column: "id_customer");

            migrationBuilder.CreateIndex(
                name: "IX_ordereds_id_Tables",
                Tables: "ordereds",
                column: "id_Tables");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTables(
                name: "Users");

            migrationBuilder.DropTables(
                name: "invoices");

            migrationBuilder.DropTables(
                name: "payments");

            migrationBuilder.DropTables(
                name: "Menus");

            migrationBuilder.DropTables(
                name: "ordereds");

            migrationBuilder.DropTables(
                name: "customers");

            migrationBuilder.DropTables(
                name: "Tables");
        }
    }
}
