using Microsoft.EntityFrameworkCore;
using PracticalTask.Models;

namespace PracticalTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
