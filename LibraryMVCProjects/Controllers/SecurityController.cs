using LibraryMVCProjects.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LibraryMVCProjects.Controllers
{
    public class SecurityController : Controller
    {
        LibraryBackendsEntities db = new LibraryBackendsEntities();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Userss userss)
        {
            var user = db.Userss.FirstOrDefault(x => x.Name == userss.Name && x.Password == userss.Password);
            if (user!=null) {


                FormsAuthentication.SetAuthCookie(user.Name, false);
                return RedirectToAction("Index", "Book");
            }
            else
            {
                ViewBag.Mesaj = "Giriş Başarısız";
                return View();
            }
            
        }

    }
}