using LibraryMVCProjects.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVCProjects.Controllers
{
    public class StudentController : Controller
    {
        LibraryBackendsEntities db = new LibraryBackendsEntities();
        public ActionResult Index()
        {
            var model = db.Students.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            return View("Yeni");

        }
    }
}