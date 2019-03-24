using Microsoft.EntityFrameworkCore.Migrations;

namespace BeersProject.Persistence.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brewery",
                columns: new[] { "Id", "City", "Name", "State" },
                values: new object[] { 1L, "Grenoble", "Brasserie Grenobloise", "open" });

            migrationBuilder.InsertData(
                table: "Beer",
                columns: new[] { "Id", "Abv", "BreweryId", "Ibu", "Name", "Ounces", "Style" },
                values: new object[] { 1L, 10m, 1L, "test", "biere test 1", 10m, "blanche" });

            migrationBuilder.InsertData(
                table: "Beer",
                columns: new[] { "Id", "Abv", "BreweryId", "Ibu", "Name", "Ounces", "Style" },
                values: new object[] { 2L, 10m, 1L, "test", "biere test 2", 10m, "blonde" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beer",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Beer",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Brewery",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
