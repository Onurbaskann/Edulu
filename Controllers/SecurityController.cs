using Edulu3.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Edulu3.Controllers
{
    public class SecurityController : Controller
    {
        EduluContext db = new EduluContext();
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var UserDb = db.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (UserDb != null)
            {
                FormsAuthentication.SetAuthCookie(UserDb.UserName, false); // Kullanıcının kimliğini doğrulamış (Authentication) oldu.  
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return View("Login");
        }
    }
}