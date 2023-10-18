using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Olympics_Larsen.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryName", "FlagImage", "GameID", "LocationID", "SportID" },
                values: new object[,]
                {
                    { "AUT", "Austria", "austria.jpg", "Para", "Out", "Can" },
                    { "BRA", "Brazil", "brazil.jpg", "Summer", "Out", "RCycle" },
                    { "CAN", "Canada", "canada.jpg", "Winter", "In", "Curl" },
                    { "CHN", "China", "china.jpg", "Summer", "In", "Dive" },
                    { "CYP", "Cyprus", "cyprus.jpg", "Youth", "In", "Bkd" },
                    { "DEU", "Germany", "germany.jpg", "Summer", "In", "Dive" },
                    { "FIN", "Finland", "finland.jpg", "Youth", "Out", "Skt" },
                    { "FRA", "France", "france.jpg", "Youth", "In", "Bkd" },
                    { "GBR", "Great Brittain", "great_brittain.jpg", "Winter", "In", "Curl" },
                    { "ITA", "Italy", "italy.jpg", "Winter", "Out", "Bob" },
                    { "JAM", "Jamaica", "jamaica.jpg", "Winter", "Out", "Bob" },
                    { "JPN", "Japan", "japan.jpg", "Winter", "Out", "Bob" },
                    { "MXN", "Mexico", "mexico.jpg", "Summer", "In", "Dive" },
                    { "NLD", "Netherlands", "netherlands.jpg", "Summer", "In", "Cyc" },
                    { "PAK", "Pakistan", "pakistan.jpg", "Para", "Out", "Can" },
                    { "PRT", "Portugal", "portugal.jpg", "Youth", "Out", "Skt" },
                    { "RUS", "Russia", "russia.jpg", "Youth", "In", "Bkd" },
                    { "SVK", "Slovakia", "slovakia.jpg", "Youth", "Out", "Skt" },
                    { "SWE", "Sweden", "sweden.jpg", "Winter", "In", "Curl" },
                    { "THA", "Thailand", "thailand.jpg", "Para", "In", "Arc" },
                    { "UKR", "Ukraine", "ukraine.jpg", "Para", "In", "Arc" },
                    { "URY", "Uruguay", "uruguay.jpg", "Para", "In", "Arc" },
                    { "USA", "United States of America", "united_states.jpg", "Summer", "Out", "RCycle" },
                    { "ZWE", "Zimbabwe", "zimbabwe.jpg", "Para", "Out", "Can" }
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
