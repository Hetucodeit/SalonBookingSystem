using Microsoft.AspNetCore.Mvc;

namespace salon.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
