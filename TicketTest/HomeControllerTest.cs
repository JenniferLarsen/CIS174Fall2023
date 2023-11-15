using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ToDoList.Controllers;
using ToDoList.Models;
using ToDoList.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TicketTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_HappyPath()
        {
            // Arrange
            var logger = new Mock<ILogger<HomeController>>();
            var repositoryMock = new Mock<ITicketRepository<Ticket>>();
            List<Ticket> ticketList = new List<Ticket>
            {
                new Ticket { TicketID = 1, Name = "First Ticket", StatusID = "todo" },
                new Ticket { TicketID = 2, Name = "Second Ticket", StatusID = "inprogress" }
            };
            repositoryMock.Setup(r => r.GetAll()).Returns(ticketList);

            HomeController controller = new HomeController(logger.Object, repositoryMock.Object);

            // Action
            var result = controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(List<Ticket>));
            var model = viewResult.Model as List<Ticket>;
            Assert.AreEqual(2, model.Count);
        }
    }
}