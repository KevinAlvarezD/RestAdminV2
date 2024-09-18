using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnOrderStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$LDbukTZ6/hgaRKDsyXYGqedi/HqVkCRuFb3Ds1Qics6cAZ95fhoju");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$0dajCxatcj0AG6QVbabsIuPeZiayjmzO4Cj/Q954SAxcecWbQAtMa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$PfqGBGy1VUrSlP5ZTXrPhODdS.9mvbpH45CqSB9WyFbiwC5yfr6/W");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$M7q6FzkKDIucKBMLMXx8SOZntRn254iy94km21CLa9k6LKJUE2MWS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$P38WO93YMUvNDuGJyjyArOLfMDtoToRtiMuKzf3ug.RW24wF0C32O");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$lxgUkXh4qua.rm6HDNA06.V5MYYWpIHrigc72S2sSj/AJDPsvYiKa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$r4vrnnMq7AmFpIo2eLzR9eh.OTy5EPHBZfJ9Nyt3JOj6psbH.7Jhm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$AYIvdtJxEzg1LsdL96IQJ.HIQ4Cw69lJwF0P10Y3U0fQLWPBOZehi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "orders");

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
    }
}
