using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticalTask.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [DisplayName("Date of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
