using classes.net.Models;

using Microsoft.AspNetCore.Mvc;

namespace classes.net.Controllers
{
    public class BirthdayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomValModal er)
        {
            if(ModelState.IsValid) 
            {
                return Content("Welcome User Your Are Validate");
            }
            return View(er);
        }
    }
}
