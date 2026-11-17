using Microsoft.AspNetCore.Mvc;

namespace Reshare.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
