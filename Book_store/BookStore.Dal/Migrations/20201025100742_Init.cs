using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false, comment: "Modified"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false, comment: "Modified"),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false, comment: "Modified"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_BookId",
                        column: x => x.BookId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false, comment: "Modified"),
                    isWishList = table.Column<bool>(nullable: false),
                    isCart = table.Column<bool>(nullable: false),
                    isOrdered = table.Column<bool>(nullable: false),
                    UserBookId = table.Column<int>(nullable: false),
                    BookUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBooks_Books_BookUserId",
                        column: x => x.BookUserId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBooks_Users_UserBookId",
                        column: x => x.UserBookId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "naziv_autora_1", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_1", 10f, 0 },
                    { 2, "naziv_autora_2", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_2", 20f, 0 },
                    { 3, "naziv_autora_3", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_3", 15f, 0 },
                    { 4, "naziv_autora_4", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_4", 25f, 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "CreatedBy", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, "Poezija", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Drama", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Adress", "CreatedAt", "CreatedBy", "Email", "FirstName", "IsAdmin", "LastName", "ModifiedAt", "Password" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 10, 22, 10, 7, 0, 0, DateTimeKind.Utc), "faruk", "ohran.faruk@hotmail.com", "Faruk", false, "Ohran", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456" },
                    { 2, null, new DateTime(2020, 10, 22, 10, 7, 0, 0, DateTimeKind.Utc), "jasir", "jasir.buric@hotmail.com", "Jasir", false, "Buric", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456" },
                    { 3, null, new DateTime(2020, 10, 22, 10, 7, 0, 0, DateTimeKind.Utc), "muhamed", "muhamed.halkic@hotmail.com", "Muhamed", false, "Halkic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456" },
                    { 4, null, new DateTime(2020, 10, 22, 10, 7, 0, 0, DateTimeKind.Utc), "mirzad", "mirzad.varupa@hotmail.com", "Mirzad", false, "Varupa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserBooks",
                columns: new[] { "Id", "BookUserId", "CreatedAt", "CreatedBy", "ModifiedAt", "UserBookId", "isCart", "isOrdered", "isWishList" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(5512), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, false, false },
                    { 2, 3, new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8325), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, false, false },
                    { 3, 4, new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8391), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, false, false },
                    { 4, 4, new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8396), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, false, false },
                    { 5, 3, new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8399), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, false, false },
                    { 6, 2, new DateTime(2020, 10, 25, 10, 7, 41, 678, DateTimeKind.Utc).AddTicks(8409), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, false, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_BookUserId",
                table: "UserBooks",
                column: "BookUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserBookId",
                table: "UserBooks",
                column: "UserBookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
