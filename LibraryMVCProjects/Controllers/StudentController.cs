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
            return View("Yeni",new Students());

        }
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Students students)
        {
            if (!ModelState.IsValid)
            {
                return View("Yeni");
            }
            if (students.Id == 0)
            {
                db.Students.Add(students);
            }
            else
            {
                var updatedEntity = db.Entry(students);
                updatedEntity.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var updatedStudent = db.Students.Find(id);
            if (updatedStudent == null)
            {
                return HttpNotFound();
            }
            return View("Yeni", updatedStudent);
        }
        public ActionResult Delete(int id)
        {
            var deletedStudent = db.Students.Find(id);
            if (deletedStudent == null)
            {
                return HttpNotFound();
            }
            db.Students.Remove(deletedStudent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}