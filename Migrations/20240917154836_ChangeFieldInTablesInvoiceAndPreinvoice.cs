using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAdminV2.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFieldInTablesInvoiceAndPreinvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "table_id",
                table: "pre_invoices",
                newName: "order_kitchen_id");

            migrationBuilder.RenameColumn(
                name: "table_id",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "order_kitchen_id",
                table: "pre_invoices",
                newName: "table_id");

            migrationBuilder.RenameColumn(
                name: "order_kitchen_id",
                table: "invoices",
                newName: "table_id");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$ISaE.KqS6s8xna/mP7D8/eQs81MlViPp6Fwi1VysWqmu.5lFsx9EO");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$WnH/HOP81LxeK5lH0nfSIeUPuOJwCPVnycdpDRfLpkWTZCyOHfxAK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$3oIo8RNQYbn0h3EN5lYqsea3mye4pNCKYcb9hxhEtMiFq7nX.INdi");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$DbhuhbnIZXnABN4fsbdbl.WUpBWB2hxZea9ktQHgAF8cnP0NKGLxK");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$UK7ecb1g4Q1nJC85oBUDqOaCohoejLhzxUbGj.haBOQJziKUvJzX2");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                column: "password",
                value: "$2a$11$jp2JQFLPqJYb0DidZpnnoO9uYqiWxc6iLEi3LRAqA9R.hLuNdPpVq");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                column: "password",
                value: "$2a$11$BQH/D1FTuvqa7mMr2apSgua5qSmKOIuuNogx/UWNPa9JJqr93x.8.");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                column: "password",
                value: "$2a$11$FeyWfH281Ij7LpqLX60R4ebGBpX7DV4CrGy61bc6iL2BGPGXhuzMK");
        }
    }
}
