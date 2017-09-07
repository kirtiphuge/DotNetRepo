using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PracMVC.Models;

namespace PracMVC.Controllers
{
    public class WelcomesController : Controller
    {
        private WelcomeDBContext db = new WelcomeDBContext();

        // GET: Welcomes
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: Welcomes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Welcome welcome = db.Movies.Find(id);
            if (welcome == null)
            {
                return HttpNotFound();
            }
            return View(welcome);
        }

        // GET: Welcomes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Welcomes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Welcome welcome)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(welcome);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(welcome);
        }

        // GET: Welcomes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Welcome welcome = db.Movies.Find(id);
            if (welcome == null)
            {
                return HttpNotFound();
            }
            return View(welcome);
        }

        // POST: Welcomes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Welcome welcome)
        {
            if (ModelState.IsValid)
            {
                db.Entry(welcome).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(welcome);
        }

        // GET: Welcomes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Welcome welcome = db.Movies.Find(id);
            if (welcome == null)
            {
                return HttpNotFound();
            }
            return View(welcome);
        }

        // POST: Welcomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Welcome welcome = db.Movies.Find(id);
            db.Movies.Remove(welcome);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
