using Microsoft.EntityFrameworkCore;


namespace Olympics_Larsen.Models

{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Sport> Sports { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "Curl", SportName = "Curling" },
                new Sport { SportID = "Bob", SportName = "Bobsleigh" },
                new Sport { SportID = "Dive", SportName = "Diving" },
                new Sport { SportID = "RCycle", SportName = "Road Cycling" },
                new Sport { SportID = "Cyc", SportName = "Cycling" },
                new Sport { SportID = "Arc", SportName = "Archery" },
                new Sport { SportID = "Can", SportName = "Canoe Sprint" },
                new Sport { SportID = "Bkd", SportName = "Breakdancing" },
                new Sport { SportID = "Skt", SportName = "Skateboarding" }
                );

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "Winter", GameName = "Winter Olympics" },
                new Game { GameID = "Summer", GameName = "Summer Olympics" },
                new Game { GameID = "Para", GameName = "Paralympics" },
                new Game { GameID = "Youth", GameName = "Youth Olympic Games" }
                );

            modelBuilder.Entity<Location>().HasData(
                new Location { LocationID = "In", LocationName = "Indoor" },
                new Location { LocationID = "Out", LocationName = "Outdoor" }
                );
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryID = "CAN", CountryName = "Canada", GameID = "Winter", SportID = "Curl", LocationID = "In", FlagImage = "canada.jpg" },
                new Country { CountryID = "SWE", CountryName = "Sweden", GameID = "Winter", SportID = "Curl", LocationID = "In", FlagImage = "sweden.jpg" },
                new Country { CountryID = "GBR", CountryName = "Great Britain", GameID = "Winter", SportID = "Curl", LocationID = "In", FlagImage = "great_britain.jpg" },
                new Country { CountryID = "JAM", CountryName = "Jamaica", GameID = "Winter", SportID = "Bob", LocationID = "Out", FlagImage = "jamaica.jpg" },
                new Country { CountryID = "ITA", CountryName = "Italy", GameID = "Winter", SportID = "Bob", LocationID = "Out", FlagImage = "italy.jpg" },
                new Country { CountryID = "JPN", CountryName = "Japan", GameID = "Winter", SportID = "Bob", LocationID = "Out", FlagImage = "japan.jpg" },
                new Country { CountryID = "DEU", CountryName = "Germany", GameID = "Summer", SportID = "Dive", LocationID = "In", FlagImage = "germany.jpg" },
                new Country { CountryID = "CHN", CountryName = "China", GameID = "Summer", SportID = "Dive", LocationID = "In", FlagImage = "china.jpg" },
                new Country { CountryID = "MXN", CountryName = "Mexico", GameID = "Summer", SportID = "Dive", LocationID = "In", FlagImage = "mexico.jpg" },
                new Country { CountryID = "BRA", CountryName = "Brazil", GameID = "Summer", SportID = "RCycle", LocationID = "Out", FlagImage = "brazil.jpg" },
                new Country { CountryID = "NLD", CountryName = "Netherlands", GameID = "Summer", SportID = "Cyc", LocationID = "In", FlagImage = "netherlands.jpg" },
                new Country { CountryID = "USA", CountryName = "United States of America", GameID = "Summer", SportID = "RCycle", LocationID = "Out", FlagImage = "united_states.jpg" },
                new Country { CountryID = "THA", CountryName = "Thailand", GameID = "Para", SportID = "Arc", LocationID = "In", FlagImage = "thailand.jpg" },
                new Country { CountryID = "URY", CountryName = "Uruguay", GameID = "Para", SportID = "Arc", LocationID = "In", FlagImage = "uruguay.jpg" },
                new Country { CountryID = "UKR", CountryName = "Ukraine", GameID = "Para", SportID = "Arc", LocationID = "In", FlagImage = "ukraine.jpg" },
                new Country { CountryID = "AUT", CountryName = "Austria", GameID = "Para", SportID = "Can", LocationID = "Out", FlagImage = "austria.jpg" },
                new Country { CountryID = "PAK", CountryName = "Pakistan", GameID = "Para", SportID = "Can", LocationID = "Out", FlagImage = "pakistan.jpg" },
                new Country { CountryID = "ZWE", CountryName = "Zimbabwe", GameID = "Para", SportID = "Can", LocationID = "Out", FlagImage = "zimbabwe.jpg" },
                new Country { CountryID = "FRA", CountryName = "France", GameID = "Youth", SportID = "Bkd", LocationID = "In", FlagImage = "france.jpg" },
                new Country { CountryID = "CYP", CountryName = "Cyprus", GameID = "Youth", SportID = "Bkd", LocationID = "In", FlagImage = "cyprus.jpg" },
                new Country { CountryID = "RUS", CountryName = "Russia", GameID = "Youth", SportID = "Bkd", LocationID = "In", FlagImage = "russia.jpg" },
                new Country { CountryID = "FIN", CountryName = "Finland", GameID = "Youth", SportID = "Skt", LocationID = "Out", FlagImage = "finland.jpg" },
                new Country { CountryID = "SVK", CountryName = "Slovakia", GameID = "Youth", SportID = "Skt", LocationID = "Out", FlagImage = "slovakia.jpg" },
                new Country { CountryID = "PRT", CountryName = "Portugal", GameID = "Youth", SportID = "Skt", LocationID = "Out", FlagImage = "portugal.jpg" }
                );

        }


    }
}
