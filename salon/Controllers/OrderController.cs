using Microsoft.AspNetCore.Mvc;

namespace salon.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
