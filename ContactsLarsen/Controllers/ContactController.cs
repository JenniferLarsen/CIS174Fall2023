using Microsoft.AspNetCore.Mvc;
using ContactsLarsen.Models;

namespace ContactsLarsen.Controllers
{
    public class ContactController : Controller
    {
        private ContactsContext context {  get; set; }
        
        public ContactController(ContactsContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Add", new Contact());
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if(contact.ContactId == 0)
                {
                    context.Add(contact);
                    context.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add": "Index";
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id) {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact contact) { 
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
