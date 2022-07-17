using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTask.Models.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<ExperienceViewModel> ListOfExperienceViewModel { get; set; }
    }
}
