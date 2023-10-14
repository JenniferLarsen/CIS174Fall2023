using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Controllers;

namespace Olympics_Larsen.Models

{
    public class CountryContext : DbContext
    {
        public CountryContext (DbContextOptions<CountryContext> options) : base(options) { }
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<Sport> Sports { get; set; } = null!;
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryID = "SWE", CountryName = "Sweden" },
                new Country { CountryID = "GBR", CountryName = "Great Brittain" },
                new Country { CountryID = "JAM", CountryName = "Jamaica" },
                new Country { CountryID = "ITA", CountryName = "Italy" },
                new Country { CountryID = "JPN", CountryName = "Japan" },
                new Country { CountryID = "DEU", CountryName = "Germany" },
                new Country { CountryID = "CHN", CountryName = "China" },
                new Country { CountryID = "MXN", CountryName = "Mexico" },
                new Country { CountryID = "BRA", CountryName = "Brazil" },
                new Country { CountryID = "NLD", CountryName = "Netherlands" },
                new Country { CountryID = "USA", CountryName = "United States of America" },
                new Country { CountryID = "THA", CountryName = "Thailand" },
                new Country { CountryID = "URY", CountryName = "Uruguay" },
                new Country { CountryID = "UKR", CountryName = "Ukraine" },
                new Country { CountryID = "AUT", CountryName = "Austria" },
                new Country { CountryID = "PAK", CountryName = "Pakistan" },
                new Country { CountryID = "ZWE", CountryName = "Zimbabwe" },
                new Country { CountryID = "FRA", CountryName = "France" },
                new Country { CountryID = "CYP", CountryName = "Cypress" },
                new Country { CountryID = "RUS", CountryName = "Russia" },
                new Country { CountryID = "FIN", CountryName = "Finland" },
                new Country { CountryID = "SVK", CountryName = "Slovakia" },
                new Country { CountryID = "PRT", CountryName = "Portugal" }
                );

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "Curl", SportName = "Curling" },
                new Sport { SportID = "Bob", SportName = "Bobsleigh" },
                new Sport { SportID = "Dive", SportName = "Diving" },
                new Sport { SportID = "RCycle", SportName = "Road Cycling" },
                new Sport { SportID = "Cyc", SportName = "Cycling" },
                new Sport { SportID = "Arc", SportName = "Archery" },
                new Sport { SportID = "Can", SportName = "Canoe Sprint" },
                new Sport { SportID = "Bkd", SportName = "Breakdancing" },
                new Sport { SportID = "Skt", SportName = "Skateboarding"}
                );

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "Winter", GameName = "Winter Olympics" },
                new Game { GameID = "Summer", GameName = "Summer Olympics" },
                new Game { GameID = "Para", GameName = "Paralympics" },
                new Game { GameID = "Youth", GameName = "Youth Olympic Games"}
                );

            modelBuilder.Entity<Location>().HasData(
                new Location { LocationID = "In", LocationName = "Indoor" },
                new Location { LocationID = "Out", LocationName = "Outdoor"}
                );
            
        }

    }
}
