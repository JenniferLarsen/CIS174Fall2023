using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment61Controller : Controller
    {
        [HttpGet("{accessLevel:int}")]
        public IActionResult Index(int accessLevel)
        {
            // Get the list of students.
            List<Student> students = new List<Student>
        {
            new Student { FirstName = "John", LastName = "Pike", Grade = 90 },
            new Student { FirstName = "Bob", LastName = "Bass", Grade = 85 },
            new Student { FirstName = "Carol", LastName = "Carp", Grade = 95 },
            new Student { FirstName = "Dave", LastName = "Walleye", Grade = 80 },
            new Student { FirstName = "Eve", LastName = "Sunny", Grade = 99 }
        };

            // Create a view model.
            Assignment61ViewModel viewModel = new Assignment61ViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            // Return the view.
            return View(viewModel);
        }
        
    }
}

