using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TestLogin.Models;

namespace TestLogin.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginModel
            {
                Username = "test",
                Password = "test"
            });
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            FormsAuthentication.RedirectFromLoginPage(model.Username, true);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}