using Microsoft.EntityFrameworkCore.Migrations;

namespace LifeList.Data.Migrations
{
    public partial class EditedBirderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85ab9a1-87b0-4192-9aca-d4fb199225bf");

            migrationBuilder.CreateTable(
                name: "Birder",
                columns: table => new
                {
                    BirderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birder", x => x.BirderId);
                    table.ForeignKey(
                        name: "FK_Birder_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb75bc58-4d17-4eeb-b734-9533a974af16", "b7c86639-8914-48aa-bf32-d03a2cd184f2", "Birder", "Birder" });

            migrationBuilder.CreateIndex(
                name: "IX_Birder_IdentityUserId",
                table: "Birder",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birder");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb75bc58-4d17-4eeb-b734-9533a974af16");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f85ab9a1-87b0-4192-9aca-d4fb199225bf", "5c6311f3-5586-4b17-8af8-02318dc157bc", "Birder", "Birder" });
        }
    }
}
