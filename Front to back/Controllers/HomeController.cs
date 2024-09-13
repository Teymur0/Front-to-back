using Microsoft.AspNetCore.Mvc;

namespace Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
