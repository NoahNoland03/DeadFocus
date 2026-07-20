using Microsoft.EntityFrameworkCore;

namespace DeadFocus.Models
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Goals> Products { get; set; }
        public DbSet<GoalProgress> GoalProgress { get; set; }
        public DbSet<GoalType> GoalType { get; set; }
        public DbSet<Quotes> Quotes { get; set; }
        public DbSet<Sessions> Sessions { get; set; }

    }
}
