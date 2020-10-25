using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isOrdered",
                table: "UserBooks");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 14, 49, 42, 138, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 14, 49, 42, 139, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 14, 49, 42, 139, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 14, 49, 42, 139, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 14, 49, 42, 139, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 14, 49, 42, 139, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.AddColumn<bool>(
                name: "isOrdered",
                table: "UserBooks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8409));
        }
    }
}
