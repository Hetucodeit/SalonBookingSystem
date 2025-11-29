using Microsoft.AspNetCore.Mvc;

namespace salon.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // No ViewBag.ShowHeaderItem = true
            // So header items stay hidden
            return View();
        }

        public IActionResult BrowseProduct()
        {
            // Keep hidden
            return View();
        }
    }
}
