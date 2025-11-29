using Microsoft.AspNetCore.Mvc;

namespace salon.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}
