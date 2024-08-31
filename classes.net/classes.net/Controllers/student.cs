using Microsoft.AspNetCore.Mvc;

namespace classes.net.Controllers
{
    public class student : Controller
    {
        // 6-aug-2024 1st class
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        // 8-aug-2024 2nd class
        public IActionResult Redirect_google()
        {
            return Redirect("https://www.google.com");
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
