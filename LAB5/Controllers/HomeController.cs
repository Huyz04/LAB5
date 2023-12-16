using LAB5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAB5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            ViewBag.error = "";
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.error = "Chưa nhập user hoặc password";
                return View();
            }
            var db = new FoodShippingContext();
            var user = db.Accounts.SingleOrDefault(m => m.Username.ToLower() == username.ToLower());
            if (user == null)
            {
                ViewBag.error = "Tài khoản không tồn tại";
                return View();
            }

            if (user.Password != password)
            {
                ViewBag.error = "Sai mật khẩu";
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}