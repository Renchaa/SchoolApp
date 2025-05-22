using System.ComponentModel.DataAnnotations;

namespace rp23052NetMD4.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Deadline is required.")]
        public DateTime Deadline { get; set; }

        [Required(ErrorMessage = "The Description is required.")]
        [StringLength(500, ErrorMessage = "The Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Course ID is required.")]
        public int CourseId { get; set; }

        // Navigācija
        public Course? Course { get; set; } // Saistība N:1 ar Course
        public ICollection<Submission>? Submissions { get; set; } // Saistība 1:N ar Submission
    }
}
