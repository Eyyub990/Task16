using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebAppOgani.Models.Contexts;
using WebAppOgani.Models.Entities;

namespace WebAppOgani.Controllers
{
    public class HomeController : Controller
    {
        public DataContext Db { get; set; }

        public HomeController(DataContext db)
        {
            Db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string fullName, string email, string message)
        {
            var post = new ContactPost {
                FullName = fullName, 
                Email = email, 
                Message = message ,
                CreatedAt = DateTime.Now
            };

            Db.ContactPosts.Add(post);
            Db.SaveChanges();

            return Json(new
            {
                error = false,
                message = "Müracietiniz qebul olundu!"
            });
        }

        [HttpPost]
        public IActionResult Subscribe(string email)
        {
            var post = new SubscribePost
            {
                Email = email
            };

            Db.SubscribePosts.Add(post);
            Db.SaveChanges();

            return Json(new
            {
                error = false,
                message = "abone olundu!"
            });
        }
    }
}
