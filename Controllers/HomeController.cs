using lr6.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user.Age >= 16)
            {
                return View("OrderProducts", user);
            }
            else
            {
                return View("NotAllowed");
            }
        }

        [HttpPost]
        public IActionResult OrderConfirmation(Product[] products)
        {
            return View(products);
        }
    }
}
