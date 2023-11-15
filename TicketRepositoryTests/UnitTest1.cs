using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ToDoList.Models;
using ToDoList.Repository;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ToDoList.Tests
{
    [TestClass]
    public class TicketRepositoryTests
    {
        DbContextOptions<TicketContext> inMemoryOptions;

        public TicketRepositoryTests()
        {
            inMemoryOptions = new DbContextOptionsBuilder<TicketContext>()
                .UseInMemoryDatabase("Filename=test.db")
                .Options;
        }

        [TestMethod]
        public void GetAllTickets_HappyPath()
        {
            // Arrange
            using (var context = new TicketContext(inMemoryOptions))
            {
                context.Statuses.Add(new Status { StatusID = "todo", StatusName = "To Do" });
                context.Tickets.Add(new Ticket { TicketID = 1, Name = "Test Ticket 1", StatusID = "todo" });
                context.Tickets.Add(new Ticket { TicketID = 2, Name = "Test Ticket 2", StatusID = "inprogress" });
                context.SaveChanges();

                ITicketRepository<Ticket> repository = new TicketRepository(context);

                // Act
                var tickets = repository.GetAll();

                // Assert
                Assert.AreEqual(2, tickets.Count());
            }
        }

        // Add more test methods for other repository methods
    }
}
