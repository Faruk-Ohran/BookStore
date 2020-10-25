using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserBookId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity", "UserBookId" },
                values: new object[] { 3, "naziv_autora_3", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_3", 15f, 0, 3 });

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 42, 44, 89, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 42, 44, 89, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 42, 44, 89, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.InsertData(
                table: "UserBooks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "UserId", "isCart", "isOrdered", "isWishList" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 10, 24, 15, 42, 44, 89, DateTimeKind.Utc).AddTicks(2507), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, false, false },
                    { 5, new DateTime(2020, 10, 24, 15, 42, 44, 89, DateTimeKind.Utc).AddTicks(2509), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, false, false },
                    { 6, new DateTime(2020, 10, 24, 15, 42, 44, 89, DateTimeKind.Utc).AddTicks(2516), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity", "UserBookId" },
                values: new object[] { 4, "naziv_autora_4", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_4", 25f, 0, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserBookId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 37, 51, 85, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 37, 51, 85, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 24, 15, 37, 51, 85, DateTimeKind.Utc).AddTicks(5331));
        }
    }
}
