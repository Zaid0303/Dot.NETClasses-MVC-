using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Template.Controllers
{
	public class UserWebController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult About()
        {
            return View();
        }

        public IActionResult product_page()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string fname, string lname, string email, string subject, string message)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            //ptmaptech@gmail.com    "ylkflsuagqvtshad"
            client.Credentials = new NetworkCredential("zaid123aptech@gmail.com", "pkoziuhxgougqimx");

            MailMessage mssg = new MailMessage(email, "zaid123aptech@gmail.com");
            mssg.Subject = "Feedback";
            mssg.Body = fname + " " + lname + " " + email + " " + subject + " " + message;

            // msg.Attachments.Add(new Attachment(PathToAttachment));
            client.Send(mssg);

            ViewBag.message = "Mail sent successfully, Role assigned";

            return View();
        }
    }
}
