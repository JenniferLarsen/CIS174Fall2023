using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Controllers;

namespace Olympics_Larsen.Models
{
    public class Sport
    {
        public string SportID { get; set; } = string.Empty;
        public string SportName { get; set;} = string.Empty;
    }
}
