using System;
using System.ComponentModel.DataAnnotations;

namespace rp23052NetMD4.Models
{
    public class Submission
    {
        public int Id { get; set; }

        [Required]
        public int AssignmentId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public DateTime SubmissionTime { get; set; }

        [Required]
        [Range(0, 100)] 
        public double Score { get; set; }

        public Assignment? Assignment { get; set; } // Saistība N:1 ar Assignment
        public Student? Student { get; set; } // Saistība N:1 ar Student
    }
}
