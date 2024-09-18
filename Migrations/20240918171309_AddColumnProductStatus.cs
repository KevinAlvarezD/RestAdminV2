using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnProductStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$xBkCblCGGsEzg/xxYl5Z1ONjTFsM.MDAw1MYTTe1hU/z6bf5h8RvO");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$oDSXLVXRKUVvltgEu5Cg5e9yEN7vT7BY.K8RN5MkaNH8mLuRGS0UK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$d36D/VDaV.Bg5PhGiWJxFedhzJsonaFvwtLoYU4WwHk/CxwqUD5aS");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$MnbB2fAR2obJUayBmEEyquzesCeGzWHwht3Zyq.yVWgGXExLwgSh2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$z2EXoeilkX1l.4nX70gj9.BA7s528yskipAQUBODLyXgglQyEEqZK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$re15cRFTTNZXRfE6ZtzCgehWfm6P8/T1iMp4ORTaqAOcUT1Tqe2EC");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$/nL0Yo/D.V3bkHDJWzmV5OlMwhlZP6n1LJrivWoIiPlisBVNatfSm");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$TfBSsYLr/72x7.v39XYca.E6gyYbGKNXf0PyJ3WFMA.KtlqRxL.06");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 12,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$q5R9ksGnqXnJyyvt0k5bEedWlN1xEbyBAcH0VJW10TzgAe8pt7/9m");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$6hUutDpT5onwM6CJQwlC.eYINVfdJyAQJTV19d0Hph6Gd4YWGy102");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$umbkz0iJ9aHz0yUW8cIBnuG5CMznSNV9fn6np7trvs58.7gT8dYqG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$ZmO9joUNFh1oH1p6tvaKlOPQHi1BbnsGsg4aoVP6ktJogAgPF1KjG");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$7WFzOWsoK/vt6VF9l1Y/yOsIM18k.DiYWXAfdTM8AIRWlFsBjhCJy");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$WOrqiMT3bZAFhWRC8FpGHeHBRjvPqpvRj2lUDpqyV/c9ZcLuuxCfa");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$j76cj4iHVmOtDirkSUaewOKvXS2eYP39VzWw.f6ACqpZ0/o5.rUgO");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$6Btndm1Rzug3CClecZNQreYGnFlYgbJImWSH5YGFX5mnmqYS3yWRG");
        }
    }
}
