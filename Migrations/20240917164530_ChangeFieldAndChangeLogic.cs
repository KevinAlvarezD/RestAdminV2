using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFieldAndChangeLogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "order_kitchen_id",
                table: "pre_invoices",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "order_kitchen_id",
                table: "invoices",
                newName: "order_id");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$ovP.zAiN4Voez1MzhfcaDeJM8oZRCTaFgcdhxEclw/OrCrYn3dGr2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$SXAhqjoHoR/XyPOSkKdSAOU5Gk8AJw4oq15g0PBhZf378Qgl0kF3G");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$ruc5SGw95dgZnYyy5OD5XeCiLAraqX8eLG3JyrsV/1CyoTVwqM87W");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$5Q8J70riuyXVw.9uW9Ag3uHKfgtWFhzRtCaR6.z.4GPuwI.Fcfesi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$KmhrJey/br1U6ImVudUa.ufNZqL6vCRVIAegcLIm/qYVnQbd4iIz2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$jF1yyyH.PCgI6gLF8pYVWuPv9qUOaBee7by8/Z985MlJCiHpQr6SC");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$zuCzF.OtznowzKQpF70AbexgWKYj3n7EiCW3bgpOWR2sj6pif1aze");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$Yc34PADXM7XzXr3hNxy3ielmykDAXAhDddvqt3d5VG5rHJ0gXt0JC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "pre_invoices",
                newName: "order_kitchen_id");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "invoices",
                newName: "order_kitchen_id");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$QqX.UvVS1W04eyX1nkaVQO.RtFrQjBM9cbsj76FLiXntt4nfTBvRu");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$PbF1AD8SBXuB3KKRvNWgtOapbLyRytB41RFNJRyPTD0.xeF4J6n..");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$7fZCl7VBgZGX2CJLvDYZzeS6TuX4b6zHEnNO0rI8Hi0RqPPqodGay");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$ezki5ZdrMBnpOQ8SuyUsLuFxuJpYgWCJjCaB7YLLbVHlmzzQuwDeW");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$FPN0s06LkCDwVaK18lyMgOFibcN4P08jzYD3Ixi4Rjx9LfljIeD3u");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$3Xu0JDsFr06PbB1dNOZGxuoOp.2YZ69ApJV4cJWoN66BdpbvlMY.q");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$5IZ.rjjYZm8jBCgDJcc4PeNggiP8kTsfaZy4IF5VcE5iyGhOtJ4mK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$bhKFUFucO5oDjpZWhx46t.2J.bh4L6emc9IYP/ID56zGWHZAk/XkW");
        }
    }
}
