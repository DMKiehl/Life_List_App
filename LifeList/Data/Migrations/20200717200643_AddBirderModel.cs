using Microsoft.EntityFrameworkCore.Migrations;

namespace LifeList.Data.Migrations
{
    public partial class AddBirderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdbffd5c-9e38-4e66-a707-aaa21564d8ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f85ab9a1-87b0-4192-9aca-d4fb199225bf", "5c6311f3-5586-4b17-8af8-02318dc157bc", "Birder", "Birder" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85ab9a1-87b0-4192-9aca-d4fb199225bf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdbffd5c-9e38-4e66-a707-aaa21564d8ff", "8cdde1e7-1917-4d7e-96ae-ba4ae7a7c7e1", "Birder", "Birder" });
        }
    }
}
