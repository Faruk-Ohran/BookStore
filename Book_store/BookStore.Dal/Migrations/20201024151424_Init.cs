using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Dal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Quantity = table.Column<int>(nullable: false),
                    UserBookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_UserBooks_UserBookId",
                        column: x => x.UserBookId,
                        principalTable: "UserBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "UserBooks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "UserId", "isCart", "isOrdered", "isWishList" },
                values: new object[] { 1, new DateTime(2020, 10, 24, 15, 14, 23, 791, DateTimeKind.Utc).AddTicks(6688), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, false, false });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity", "UserBookId" },
                values: new object[] { 1, "naziv_autora_1", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_1", 10f, 0, 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Description", "Image", "ModifiedAt", "Name", "Price", "Quantity", "UserBookId" },
                values: new object[] { 2, "naziv_autora_2", new DateTime(2020, 10, 23, 10, 0, 0, 0, DateTimeKind.Utc), "faruk", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "naziv_knjige_2", 20f, 0, 1 });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserBookId",
                table: "Books",
                column: "UserBookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
