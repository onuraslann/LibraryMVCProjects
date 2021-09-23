using LibraryMVCProjects.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVCProjects.Controllers
{
    public class WriterController : Controller
    {
        LibraryBackendsEntities db = new LibraryBackendsEntities();
        public ActionResult Index()
        {
            var model = db.Writers.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            return View("Yeni");
        }
        public ActionResult Kaydet(Writers writers)
        {
            if (writers.Id == 0)
            {
                db.Writers.Add(writers);
            }
            else
            {
                var updatedEntity = db.Entry(writers);
                updatedEntity.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var updatedWriter = db.Writers.Find(id);
            if (updatedWriter == null)
            {
                return HttpNotFound();
            }
            return View("Yeni", updatedWriter);
        }
        public ActionResult Delete(int id)
        {
            var deletedWriter = db.Writers.Find(id);
            if (deletedWriter == null)
            {
                return HttpNotFound();
            }
            db.Writers.Remove(deletedWriter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}