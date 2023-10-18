using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Controllers;
using Olympics_Larsen.Models;

namespace Olympics_Larsen.Models
{
    public class Game
    {
        public string GameID { get; set; } = string.Empty;
        public string GameName { get; set;} = string.Empty;
    }
}
