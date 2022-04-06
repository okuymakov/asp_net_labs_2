using asp_net_labs_2_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp_net_labs_2_2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var login = HttpContext.Session.GetString("login");
            var password = HttpContext.Session.GetString("password");
            var model = new LoginViewModel()
            {
                Login = login,
                Password = password
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("login", model.Login);
                HttpContext.Session.SetString("password", model.Password);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
