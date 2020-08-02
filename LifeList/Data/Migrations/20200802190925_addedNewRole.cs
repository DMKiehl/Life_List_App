using Microsoft.EntityFrameworkCore.Migrations;

namespace LifeList.Data.Migrations
{
    public partial class addedNewRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25887bed-991e-4ec6-9b2e-936b21f28867");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72a8e5b1-3b24-4063-a71d-61a6eebc35ab", "40aa680f-f7d6-4420-9a70-87e8f300cf77", "Birder", "Birder" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ef2af1d-6a0b-4e7f-9655-884f34e343ca", "1570be69-582f-499d-9f68-eb10ac6daa82", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72a8e5b1-3b24-4063-a71d-61a6eebc35ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef2af1d-6a0b-4e7f-9655-884f34e343ca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25887bed-991e-4ec6-9b2e-936b21f28867", "0557c08f-cfd6-46f8-9a36-f1b2aa2a6095", "Birder", "Birder" });
        }
    }
}
