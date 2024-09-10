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
                    id_Order = Tables.Column<int>(type: "int", nullable: false),
                    id_Menu = Tables.Column<int>(type: "int", nullable: false),
                    quantity = Tables.Column<int>(type: "int", nullable: false),
                    unit_price = Tables.Column<double>(type: "double", nullable: false)
                },
                constraints: Tables =>
                {
                    Tables.PrimaryKey("PK_order_details", x => x.id);
                    Tables.ForeignKey(
                        name: "FK_order_details_Orders_id_Order",
                        column: x => x.id_Order,
                        principalTables: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    Tables.ForeignKey(
                        name: "FK_order_details_Menus_id_Menu",
                        column: x => x.id_Menu,
                        principalTables: "Menus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_id_Order",
                Tables: "order_details",
                column: "id_Order");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_id_Menu",
                Tables: "order_details",
                column: "id_Menu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTables(
                name: "order_details");
        }
    }
}
