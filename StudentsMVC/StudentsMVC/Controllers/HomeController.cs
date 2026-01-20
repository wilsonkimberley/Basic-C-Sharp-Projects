using Microsoft.AspNetCore.Mvc;

namespace StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Page - Academy of Learning";
            return View();
        }
        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult Instructors()
        {
            return View();
        }
    }
}
