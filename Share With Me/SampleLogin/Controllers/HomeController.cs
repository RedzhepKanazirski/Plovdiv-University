using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShareWithMe.Database;
using ShareWithMe.Entities;
using ShareWithMe.ViewModels.Home;

namespace ShareWithMe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove("LoggedUserId");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.HttpContext.Session.GetString("LoggedUserId") != null)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (this.HttpContext.Session.GetString("LoggedUserId") != null)
                return RedirectToAction("Index", "Home");

            if (!ModelState.IsValid)
                return View(model);

            MyDbContext context = new MyDbContext();
            User loggedUser = context.Users.Where(u => u.Username == model.Username &&
                                                       u.Password == model.Password)
                                           .FirstOrDefault();

            if (loggedUser == null)
            {
                ModelState.AddModelError("AuthenticationFailed", "Wrong username or password");
                return View(model);
            }

            this.HttpContext.Session.SetString("LoggedUserId", loggedUser.Id.ToString());
            this.HttpContext.Session.SetString("LoggedUserUsername", loggedUser.Username);

            return RedirectToAction("Index", "Home");
        }
    }
}