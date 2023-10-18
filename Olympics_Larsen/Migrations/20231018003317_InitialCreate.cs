using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Olympics_Larsen.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SportName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID");
                    table.ForeignKey(
                        name: "FK_Countries_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryName", "FlagImage", "GameID", "LocationID", "SportID" },
                values: new object[,]
                {
                    { "AUT", "Austria", "", null, null, null },
                    { "BRA", "Brazil", "", null, null, null },
                    { "CHN", "China", "", null, null, null },
                    { "CYP", "Cypress", "", null, null, null },
                    { "DEU", "Germany", "", null, null, null },
                    { "FIN", "Finland", "", null, null, null },
                    { "FRA", "France", "", null, null, null },
                    { "GBR", "Great Brittain", "", null, null, null },
                    { "ITA", "Italy", "", null, null, null },
                    { "JAM", "Jamaica", "", null, null, null },
                    { "JPN", "Japan", "", null, null, null },
                    { "MXN", "Mexico", "", null, null, null },
                    { "NLD", "Netherlands", "", null, null, null },
                    { "PAK", "Pakistan", "", null, null, null },
                    { "PRT", "Portugal", "", null, null, null },
                    { "RUS", "Russia", "", null, null, null },
                    { "SVK", "Slovakia", "", null, null, null },
                    { "SWE", "Sweden", "", null, null, null },
                    { "THA", "Thailand", "", null, null, null },
                    { "UKR", "Ukraine", "", null, null, null },
                    { "URY", "Uruguay", "", null, null, null },
                    { "USA", "United States of America", "", null, null, null },
                    { "ZWE", "Zimbabwe", "", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "GameName" },
                values: new object[,]
                {
                    { "Para", "Paralympics" },
                    { "Summer", "Summer Olympics" },
                    { "Winter", "Winter Olympics" },
                    { "Youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { "In", "Indoor" },
                    { "Out", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "SportName" },
                values: new object[,]
                {
                    { "Arc", "Archery" },
                    { "Bkd", "Breakdancing" },
                    { "Bob", "Bobsleigh" },
                    { "Can", "Canoe Sprint" },
                    { "Curl", "Curling" },
                    { "Cyc", "Cycling" },
                    { "Dive", "Diving" },
                    { "RCycle", "Road Cycling" },
                    { "Skt", "Skateboarding" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_LocationID",
                table: "Countries",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
