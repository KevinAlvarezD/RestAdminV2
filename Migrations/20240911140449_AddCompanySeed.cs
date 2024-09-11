using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "company",
                columns: new[] { "id", "address", "email", "logo_url", "name", "nit", "phone" },
                values: new object[] { 1, "Cra 50 40 90", "administracionilforno@ilforno.com", "https://images.rappi.com/restaurants_logo/il-forno-logo1-1568819470999.png", "Il Forno", "49879684184", "3242144893" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "company",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
