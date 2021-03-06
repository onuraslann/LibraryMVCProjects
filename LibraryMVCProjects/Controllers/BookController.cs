using LibraryMVCProjects.Models.EntityFramework;
using LibraryMVCProjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVCProjects.Controllers
{
    [Authorize(Roles ="Admin")]
    public class BookController : Controller
    {
        LibraryBackendsEntities db = new LibraryBackendsEntities();
        public ActionResult Index()
        {
            var model = db.Books.ToList();
            return View(model);
        }
    
        public ActionResult Yeni()
        {
            var model = new BookViewModels() { 
            
                 BookTypes=db.BookTypes.ToList(),
                 Writers=db.Writers.ToList(),
                  Books=new Books()

            };
            return View("Yeni", model);
        }
        public ActionResult Kaydet(Books books)
        {
            if (!ModelState.IsValid)
            {
                var model = new BookViewModels()
                {

                    BookTypes = db.BookTypes.ToList(),
                    Writers = db.Writers.ToList(),
                     Books=books

                };
                return View("Yeni", model);

            }
            if (books.Id == 0)
            {
                db.Books.Add(books);
            }
            else
            {
                var updatedEntity = db.Entry(books);
                updatedEntity.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new BookViewModels()
            {

                BookTypes = db.BookTypes.ToList(),
                Writers = db.Writers.ToList(),
                 Books=db.Books.Find(id)

            };
            return View("Yeni", model);
        }
        public ActionResult Delete(int id)
        {
            var deletedModel = db.Books.Find(id);
            if (deletedModel == null)
            {
                return HttpNotFound();
            }
            db.Books.Remove(deletedModel);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}