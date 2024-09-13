using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeOfEncrypt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$UACBfjkYjZMqcGsi9B4ep.wZVgyrreS5EKGXtHLcZrmGltxoPUh..");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$.WZ/zKn3BKfCD5ceCi9rBezMpWqWdjTjN1IB5Egx6JcPzBrhGHLHi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$p3xDFMrDG.AQ8hmupg/2H.7StZ4T6ND8GFVf0XO3HwrPNQDSEtuIG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$sF/ukyY9c31O4DZa1/zOOeD.Qu5PrTTt/coLXGnwHpNYhL/4ejCSS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$KXddNSE4pXecZt6HFaeoSOleGhRUcWyK2a5IlbjCnOQQhWLeJbaxu");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$86xXWNKpX1bl6Dwwbljlje6esn6NfedUAmtkIbnQbWGbqRGcK3tKC");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$C4iflfAJs09jTnTf22yXGuKms/uX7n5vkzO137SgxRJHAoZRpZuXW");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$gaY.lJYyAwBpGBlQ9QKaRuy8OfEXO.UdG4xKHGkeZG9I74enZreyi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "AQAAAAIAAYagAAAAEPOzsYRAnnbP/bMCZfTjM/mqHuRBDzuUsqsqV/lAh5tjEosYrRPEUjm/EZ/j/11CXw==");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "AQAAAAIAAYagAAAAENArCtTZCXwDPtf24qZAtVUrDtuJsazS64XwB7XXk0JZQ3WpKtcSNSTPDKybJo0+UA==");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "AQAAAAIAAYagAAAAEMqnGx8vBPemTEfYyF474rFwP/ybupkMWINQkhD31lmsdXeNGNcVGp4MK3U7vcBIBw==");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "AQAAAAIAAYagAAAAEHRkAMJ2cvyQWzIWf+H79icCbGGRsVd+fx/QnQv0zTqWWwKXpKH6Kmi++UWyiTZ+Jw==");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "AQAAAAIAAYagAAAAEG+spgF7KErkLD5p2+nVRGgI3gpI5SrMJRthfcrp4so0RAWFgCbfmXwf+upI7CWJuQ==");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "AQAAAAIAAYagAAAAEA9KL3/+oT9nRbHBdtrA6dONioiWPT5z8UmgsenTBVpAKPJrs3fYf+7lLwXp4g73sw==");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "AQAAAAIAAYagAAAAEH5V8aE5ScInsNdE3vlzEc/+R6AXgAOB1AxNlNUYziBlUmH57mqJ+sY8gl8Wj1jecg==");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "AQAAAAIAAYagAAAAEPGHMetKXRxCfIOH9agZBdBrWTHxvVZT3+6VX+bLjVLIJvK1w3Xy81cjqhh10zXDLA==");
        }
    }
}
