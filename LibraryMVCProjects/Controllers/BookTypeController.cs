using LibraryMVCProjects.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVCProjects.Controllers
{
    public class BookTypeController : Controller
    {
        LibraryBackendsEntities db = new LibraryBackendsEntities();
        public ActionResult Index()
        {
            var model = db.BookTypes.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            return View("Yeni");
        }
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(BookTypes booktypes)
        {
            if (booktypes.Id == 0)
            {
                db.BookTypes.Add(booktypes);
            }
            else
            {
                var updatedEntity = db.Entry(booktypes);
                updatedEntity.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var updatedType = db.BookTypes.Find(id);
            if (updatedType == null)
            {
                return HttpNotFound();
            }
            return View("Yeni", updatedType);
        }
        public ActionResult Delete(int id)
        {
            var deletedType = db.BookTypes.Find(id);
            if (deletedType == null)
            {
                return HttpNotFound();
            }
            db.BookTypes.Remove(deletedType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
