using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PracticalTask.Data;
using PracticalTask.Models;
using PracticalTask.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<User> users = _context.Users
                .Include(e=>e.Experiences)
                .OrderByDescending(o => o.Id).ToList();

            return View(users);
        }

        //GET: Get user profile form
        public IActionResult Create()
        {
            return View();
        }

        //POST: Post user profile form
        [HttpPost]
        public JsonResult Create(UserViewModel userViewModel)
        {
            User user = new User();
            user.FirstName = userViewModel.FirstName;
            user.LastName = userViewModel.LastName;
            user.Email = userViewModel.Email;
            user.Address = userViewModel.Address;
            user.DateOfBirth = userViewModel.DateOfBirth;

            _context.Users.Add(user);
            _context.SaveChanges();

            //it should select same user ...I did it just for demo
            user = _context.Users.FirstOrDefault(u=>u.FirstName == userViewModel.FirstName);

            foreach(var experience in userViewModel.ListOfExperienceViewModel)
            {
                Experience objExp = new Experience();
                objExp.CompanyName = experience.CompanyName;
                objExp.Position = experience.CompanyName;
                objExp.FromDate = experience.FromDate;
                objExp.ToDate = experience.ToDate;
                objExp.UserId = user.Id;

                _context.Experiences.Add(objExp);
                _context.SaveChanges();
            }

            return Json(new { Success = true, Message="Data added successfully"});
        }
    }
}
