using Microsoft.AspNetCore.Mvc;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Rim()
        {
            return View();
        }
    }
}
