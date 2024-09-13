using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddSistemAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "image_url",
                table: "products",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "order_products");

            migrationBuilder.DropColumn(
                name: "observations",
                table: "invoices");

            migrationBuilder.AlterColumn<string>(
                name: "image_url",
                table: "products",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "riwi1234");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "Susana1901");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "21354");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "12345678");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "987654321");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "laura2024");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "admin2024");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "cashier2024");
        }
    }
}
