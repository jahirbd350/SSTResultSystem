using SSTResultSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSTResultSystem.Controllers
{
    public class LoginController : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(user userInfo)
        {
            var loginchek = db.users.Where(x => x.username.Equals(userInfo.username) && x.password.Equals(userInfo.password)).FirstOrDefault();
            if (loginchek != null)
            {
                Session["id"] =Convert.ToInt32(userInfo.id);
                Session["username"] = userInfo.username.ToString();
                return RedirectToAction("index", "Dashboard");
            }
            else
            {
                Session["err"] = " UserName or Password Incorrect!";
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("index", "Login");
        }
    }
}
