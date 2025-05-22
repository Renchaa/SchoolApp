using System.ComponentModel.DataAnnotations;

namespace rp23052NetMD4.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Course Name is required.")]
        [StringLength(100, ErrorMessage = "The Course Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Teacher ID is required.")]
        public int TeacherId { get; set; }

        
        public Teacher? Teacher { get; set; } // Saistība N:1 ar Teacher
        public ICollection<Assignment>? Assignments { get; set; } // Saistība 1:N ar Assignment
    }
}
