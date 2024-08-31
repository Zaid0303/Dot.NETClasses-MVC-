using Microsoft.AspNetCore.Mvc;

namespace classes.net.Controllers
{
    public class StdInfo : Controller
    {
        public IActionResult Index()
        {
            TempData.Keep("address");
            return View();
        }

        [HttpGet]
        public IActionResult Data()
        {
            ViewBag.Name = "Zaid";
            ViewData["Num"] = 0318;
            TempData["address"] = "Home2";
            TempData.Keep("address");
            return View();
        }
    }
}
