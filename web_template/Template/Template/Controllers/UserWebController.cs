using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
	public class UserWebController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
