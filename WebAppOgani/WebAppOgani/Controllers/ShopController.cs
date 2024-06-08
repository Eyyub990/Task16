using Microsoft.AspNetCore.Mvc;

namespace WebAppOgani.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Basket()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
