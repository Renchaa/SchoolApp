using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace rp23052NetMD4.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; } = "";

        [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
        public string Address { get; set; } = "";

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
