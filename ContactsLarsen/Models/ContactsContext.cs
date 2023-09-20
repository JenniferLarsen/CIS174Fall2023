using Microsoft.EntityFrameworkCore;

namespace ContactsLarsen.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) 
            : base(options) 
        { }

        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                Name = "Jennifer",
                PhoneNumber = 5158675309,
                Address = "184 S 6th St, St Helens, IA 51111",
                Note = "La Vie est Belle."
            },

            new Contact
            {
                ContactId = 2,
                Name = "Asecond Person",
                PhoneNumber = 5155555555,
                Address = "123 S 6th St, St Helens, IA 52222",
                Note = "A second Note."
            },

            new Contact
            {
                ContactId = 3,
                Name = "Athird Person",
                PhoneNumber = 5155554444,
                Address = "432 S 6th St, St Helens, IA 53333",
                Note = "Sometimes."
            }
        );
        }
    }
}
