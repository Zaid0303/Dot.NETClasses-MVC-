using Microsoft.AspNetCore.Mvc;

namespace classes.net.Models
{
    public class Prod : Controller
    {
        public IActionResult Index()
        {

            Product pro = new Product() 
            { 
                Title = "Smart Watch",
                Price = 1300,
                Image = "12mini_.jpg"

            }; return View(pro);

        }
    }
}
