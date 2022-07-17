using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticalTask.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }

        [Required]
        public string CompanyName { get; set; }
        
        [Required]
        public string Position { get; set; }        

        [Required]       
        public DateTime FromDate { get; set; }

        [Required]        
        public DateTime ToDate { get; set; }        
        
        [Required]
        public int UserId { get; set; }       
    }
}
