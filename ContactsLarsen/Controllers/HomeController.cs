using Microsoft.AspNetCore.Mvc;
using ContactsLarsen.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsLarsen.Controllers
{
    public class HomeController : Controller
    {
        private ContactsContext context {  get; set; }

        public HomeController(ContactsContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}
