using Microsoft.AspNetCore.Mvc;

namespace DeadFocus.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
