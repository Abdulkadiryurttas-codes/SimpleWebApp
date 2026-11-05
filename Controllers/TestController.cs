using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyAction()
        {
            return View();
        }

        public IActionResult MyAction2()
        {
            return View("FarklıView");
        }
    }
}
