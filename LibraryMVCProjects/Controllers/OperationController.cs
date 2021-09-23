using LibraryMVCProjects.Models.EntityFramework;
using LibraryMVCProjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVCProjects.Controllers
{
    public class OperationController : Controller
    {
        LibraryBackendsEntities db = new LibraryBackendsEntities();
        public ActionResult Index()
        {
            var model = db.Operations.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            var model = new OperationViewModels()
            {
                 Books=db.Books.ToList(),
                 Students=db.Students.ToList()
            };
            return View("Yeni", model);
        }
        public ActionResult Kaydet(Operations operations)
        {
            if (operations.Id == 0)
            {
                db.Operations.Add(operations);
            }
            else
            {
                var updatedEntity = db.Entry(operations);
                updatedEntity.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new OperationViewModels()
            {
                Books = db.Books.ToList(),
                Students = db.Students.ToList(),
                Operations = db.Operations.Find(id)
            };
            return View("Yeni", model);
        }
        public ActionResult Delete(int id)
        {
            var deletedOperation = db.Operations.Find(id);
            if (deletedOperation == null)
            {
                return HttpNotFound();
            }
            db.Operations.Remove(deletedOperation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}