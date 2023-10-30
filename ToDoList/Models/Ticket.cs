using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ToDoList.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }

        [Required (ErrorMessage = "Please enter a Name.")]
        [StringLength (30, ErrorMessage = "Name must be 30 characters or less.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Description.")]
        [StringLength(30, ErrorMessage = "Description must be 30 characters or less.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Sprint Number between 1 and 100.")]
        [Range(1, 100, ErrorMessage = "Sprint Number must be between 1 and 100.")]
        public string SprintNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a Point Value between 1 and 5.")]
        [Range(1, 5, ErrorMessage = "Point value must be between 1 and 5")]
        public string PointValue { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a Status.")]
        public string StatusID  { get; set; } = string.Empty;
        
        [ValidateNever]
        public Status Status { get; set; } = null!;

    }
}
