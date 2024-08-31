using Microsoft.AspNetCore.Mvc;

namespace classes.net.Controllers
{
    public class Form : Controller
    {
        public IActionResult Index()
        {
            TempData.Keep("Productqty");
            return View();

        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Index(String FirstName,  String LastName)
        //{
        //    ViewBag.Name = string.Format("Full Name: {0} {1}", FirstName, LastName);
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(String FirstNum, String LastNum)
        {
            int num1 = Convert.ToInt32(FirstNum);
            int num2 = Convert.ToInt32(LastNum);
            int sum = num1 + num2;
            ViewBag.Name = $"Answer: {sum}";
            return View();
        }

        public IActionResult Details() 
        {
            ViewBag.ProductTitle = "Toys";  // ViewBag = single value
            ViewBag.ProductPrice = 500;
            ViewData["ProductTitle"] = "car toy";  // ViewData = bunch of key value
            TempData["Productqty"] = "200"; // TempData = ek controller ky dusrt controller ky view mein send kr ta hy 
            TempData.Keep("Productqty"); // keep = apny pass rakh ta hy
            return View();
        }



    }
}
