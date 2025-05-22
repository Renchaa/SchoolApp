using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rp23052NetMD4.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)] 
        public string Surname { get; set; }

        [Required]
        [MaxLength(10)] 
        public string Gender { get; set; }

        [Required]
        public DateTime ContractDate { get; set; }

        public ICollection<Course> Courses { get; set; } // Saistība 1:N ar Course
    }
}
