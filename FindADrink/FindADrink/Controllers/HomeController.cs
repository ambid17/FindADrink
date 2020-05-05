using Microsoft.AspNetCore.Mvc;

namespace FindADrink.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
