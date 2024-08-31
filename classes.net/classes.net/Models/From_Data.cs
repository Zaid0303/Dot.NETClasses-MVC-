using Microsoft.AspNetCore.Mvc;

namespace classes.net.Models
{
    public class From_Data : Controller
    {
        [HttpPost]
        public IActionResult Index(string Name, string Email, int age)
        {
            Form_Variable fv = new Form_Variable()
            {
                Name = Name,
                Email = Email,
                Age = Convert.ToString(age),
            };
            return View(fv);
        }
    }
}
