
using Microsoft.AspNetCore.Mvc;
using ReShare.Models;

namespace ReShare.Controllers
{
    public class DonorController : Controller
    {
        public static List<Donation> Donations = new List<Donation>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDonation(Donation donation)
        {
            donation.Id = Donations.Count + 1;

            Donations.Add(donation);

            return RedirectToAction("Index", "Recipient");
        }
    }
}
