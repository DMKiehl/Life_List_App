using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LifeList.Data.Migrations
{
    public partial class addedBirdModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb75bc58-4d17-4eeb-b734-9533a974af16");

            migrationBuilder.CreateTable(
                name: "Bird",
                columns: table => new
                {
                    BirdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommonName = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    SpeciesFamily = table.Column<string>(nullable: true),
                    DateSeen = table.Column<DateTime>(nullable: false),
                    CitySeen = table.Column<string>(nullable: true),
                    StateSeen = table.Column<string>(nullable: true),
                    ProvinceSeen = table.Column<string>(nullable: true),
                    Continent = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bird", x => x.BirdId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25887bed-991e-4ec6-9b2e-936b21f28867", "0557c08f-cfd6-46f8-9a36-f1b2aa2a6095", "Birder", "Birder" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bird");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25887bed-991e-4ec6-9b2e-936b21f28867");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb75bc58-4d17-4eeb-b734-9533a974af16", "b7c86639-8914-48aa-bf32-d03a2cd184f2", "Birder", "Birder" });
        }
    }
}
