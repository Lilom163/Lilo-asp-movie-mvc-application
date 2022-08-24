using Microsoft.AspNetCore.Mvc;

namespace MediMoovi.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
