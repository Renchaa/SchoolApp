using System.ComponentModel.DataAnnotations;

namespace rp23052NetMD4.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters.")]
        public string Surname { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Gender must be either 'Male', 'Female' or similar.")]
        public string Gender { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Student ID Number cannot be longer than 15 characters.")]
        public string StudentIdNumber { get; set; }

        public ICollection<Submission>? Submissions { get; set; } // Saistība 1:N ar Submission
    }
}
