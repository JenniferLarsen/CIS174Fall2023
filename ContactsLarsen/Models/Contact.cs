using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsLarsen.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incremented primary key
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name. ")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number. ")]
        public long PhoneNumber { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + Name?.ToString();
    }
}
