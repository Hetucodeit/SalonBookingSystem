using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using salon.Models;

namespace salon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
<<<<<<< HEAD
            ViewBag.ShowHeaderItem = true;
=======
            ViewBag.ShowheaderItem = true;
>>>>>>> 02d7538543e94806ed50eff245549ee45f14184c
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
