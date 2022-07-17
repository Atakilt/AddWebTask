using System;

namespace PracticalTask.Models.ViewModels
{
    public class ExperienceViewModel
    {
        public int ExperienceId { get; set; }
        public string Position { get; set; }
        public string CompanyName { get; set; }       
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
