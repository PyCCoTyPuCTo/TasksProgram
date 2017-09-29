using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksProgram.Models;

namespace TasksProgram.Controllers
{
    public class HomeController : Controller
    {

        TaskContext db = new TaskContext();

        public ActionResult Index()
        {
                return View(db.Tasks);
        }

        [HttpGet]
        public ActionResult EditTask(int? id)
        {
                if (id == null)
                    return HttpNotFound();

                Task task = db.Tasks.Find(id);
                if (task != null)
                    return (View(task));
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditTask(Task task)
        {
            if (ModelState.IsValid)
            {
                    db.Entry(task).State = EntityState.Modified;
                    db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNew(Task task)
        {
            if (ModelState.IsValid)
            {
                    db.Entry(task).State = EntityState.Added;
                    db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(task);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
                Task deleteTask = db.Tasks.Find(id);
                if (deleteTask == null)
                {
                    return HttpNotFound();
                }

                db.Tasks.Remove(deleteTask);
                db.SaveChanges();
                return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
                db.Dispose();
                base.Dispose(disposing);
        }
    }
}