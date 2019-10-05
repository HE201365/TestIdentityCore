using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityProject.Data.Migrations
{
    public partial class CategoryItemsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ParentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<long>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryCode", "Name", "Notes", "ParentId" },
                values: new object[] { 1L, "c123", "Electronic", "some notes for Electronics", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryCode", "Name", "Notes", "ParentId" },
                values: new object[] { 2L, "c1234", "Tablet", "some notes for tablets", 1L });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryCode", "Name", "Notes", "ParentId" },
                values: new object[] { 3L, "c1235", "PC", "some notes for PC", 1L });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "Name" },
                values: new object[] { 3L, "e0058870-35d5-4456-a532-754bbcb1b646", 1L, "Frigo" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "Name" },
                values: new object[] { 1L, "e0058870-35d5-4456-a532-754bbcb1b646", 2L, "IPad" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ApplicationUserId", "CategoryId", "Name" },
                values: new object[] { 2L, "e0058870-35d5-4456-a532-754bbcb1b646", 3L, "MS Surface" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ApplicationUserId",
                table: "Items",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
