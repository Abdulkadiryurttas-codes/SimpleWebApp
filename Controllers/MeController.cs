using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class MeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Egitim()
        {
            return View();
        }

        public IActionResult Yetenek()
        {
            return View();
        }
    }

}
