using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Controllers;

namespace Olympics_Larsen.Models
{
    public class Location
    {
        public string LocationID { get; set; } = string.Empty;
        public string LocationName { get; set; } = string.Empty;
    }
}
