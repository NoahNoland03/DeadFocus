using DeadFocus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DeadFocus.Controllers
{
    public class DashboardController : Controller
    {
        //dependency injection to get the database connection from the application
        // creates a variable to store database connection in 
        private readonly ApplicationDbContext _context;

        //constructor to initialize the database connection
        //takes in the database connection as a parameter context and assigns it to the variable _context
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
           
            
            var quotes = await _context.Quotes.ToListAsync();
            
            Random rnd = new Random();
            int randomIndex = rnd.Next(quotes.Count);
            Quotes quote = quotes[randomIndex];

            return View(quote);
        }

        public IActionResult AddGoal() 
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddGoalItem(Goals goal)
        {
            
           
                // Set default values

                goal.GoalStatusId = false;          // Goal is not completed
                goal.StartDate = DateTime.UtcNow;   // Creation date
                goal.DateTime = DateTime.MinValue;  // Not completed yet
                goal.GoalTypeId = 1;                // Default goal type

                _context.Goals.Add(goal);
                _context.SaveChanges();



                return RedirectToAction("Index", new { id = goal.GoalId });
            

        }
    }
}
