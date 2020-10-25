using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 37, 51, 85, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.InsertData(
                table: "UserBooks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "UserId", "isCart", "isOrdered", "isWishList" },
                values: new object[] { 3, new DateTime(2020, 10, 24, 15, 37, 51, 85, DateTimeKind.Utc).AddTicks(5331), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, false, false });

            migrationBuilder.InsertData(
                table: "UserBooks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "UserId", "isCart", "isOrdered", "isWishList" },
                values: new object[] { 2, new DateTime(2020, 10, 24, 15, 37, 51, 85, DateTimeKind.Utc).AddTicks(5293), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, false, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 14, 23, 791, DateTimeKind.Utc).AddTicks(6688));
        }
    }
}
