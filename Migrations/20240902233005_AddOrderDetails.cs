using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTables(
                name: "order_details",
                columns: Tables => new
                {
                    id = Tables.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_ordered = Tables.Column<int>(type: "int", nullable: false),
                    id_product = Tables.Column<int>(type: "int", nullable: false),
                    quantity = Tables.Column<int>(type: "int", nullable: false),
                    unit_price = Tables.Column<double>(type: "double", nullable: false)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_order_details", x => x.id);
                    Tables.ForeignKey(
                        name: "FK_order_details_ordereds_id_ordered",
                        column: x => x.id_ordered,
                        principalTables: "ordereds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    Tables.ForeignKey(
                        name: "FK_order_details_products_id_product",
                        column: x => x.id_product,
                        principalTables: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_id_ordered",
                Tables: "order_details",
                column: "id_ordered");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_id_product",
                Tables: "order_details",
                column: "id_product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTables(
                name: "order_details");
        }
    }
}
