using Microsoft.EntityFrameworkCore.Migrations;

namespace BeersProject.Persistence.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brewery",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brewery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beer",
                columns: table => new
                {
                    Abv = table.Column<decimal>(nullable: true),
                    Ibu = table.Column<string>(nullable: true),
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    BreweryId = table.Column<long>(nullable: false),
                    Ounces = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beer", x => x.Id);
                    table.ForeignKey(
                        name: "fk_brewery_id",
                        column: x => x.BreweryId,
                        principalTable: "Brewery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BreweryRating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BreweryId = table.Column<long>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Rating = table.Column<decimal>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreweryRating", x => x.Id);
                    table.ForeignKey(
                        name: "fk_brewery_rating_brewery",
                        column: x => x.BreweryId,
                        principalTable: "Brewery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_brewery_rating_user",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BeerRating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BeerId = table.Column<long>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Rating = table.Column<decimal>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeerRating", x => x.Id);
                    table.ForeignKey(
                        name: "fk_beer_id",
                        column: x => x.BeerId,
                        principalTable: "Beer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_user_id",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beer_BreweryId",
                table: "Beer",
                column: "BreweryId");

            migrationBuilder.CreateIndex(
                name: "IX_BeerRating_BeerId",
                table: "BeerRating",
                column: "BeerId");

            migrationBuilder.CreateIndex(
                name: "IX_BeerRating_UserId",
                table: "BeerRating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BreweryRating_BreweryId",
                table: "BreweryRating",
                column: "BreweryId");

            migrationBuilder.CreateIndex(
                name: "IX_BreweryRating_UserId",
                table: "BreweryRating",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeerRating");

            migrationBuilder.DropTable(
                name: "BreweryRating");

            migrationBuilder.DropTable(
                name: "Beer");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Brewery");
        }
    }
}
