
using Microsoft.AspNetCore.Mvc;
using ReShare.Controllers;

namespace ReShare.Controllers
{
    public class RecipientController : Controller
    {
        public IActionResult Index()
        {
            return View(DonorController.Donations);
        }
    }
}
