using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SSTResultSystem.Models;

namespace SSTResultSystem.Controllers
{
    public class Result42Controller : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();

        // GET: Result42
        public ActionResult Index()
        {
            return View(db.result42.ToList());
        }

        // GET: Result42/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result42 result42 = db.result42.Find(id);
            if (result42 == null)
            {
                return HttpNotFound();
            }
            return View(result42);
        }

        // GET: Result42/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result42/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studentid,examterm,cse4231,cse4232,cse42p3,cse4234,cse42p5,cse4246,cse4227")] result42 result42)
        {
            if (ModelState.IsValid)
            {
                db.result42.Add(result42);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result42);
        }

        // GET: Result42/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result42 result42 = db.result42.Find(id);
            if (result42 == null)
            {
                return HttpNotFound();
            }
            return View(result42);
        }

        // POST: Result42/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studentid,examterm,cse4231,cse4232,cse42p3,cse4234,cse42p5,cse4246,cse4227")] result42 result42)
        {
            if (ModelState.IsValid)
            {
                db.Entry(result42).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(result42);
        }

        // GET: Result42/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result42 result42 = db.result42.Find(id);
            if (result42 == null)
            {
                return HttpNotFound();
            }
            return View(result42);
        }

        // POST: Result42/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            result42 result42 = db.result42.Find(id);
            db.result42.Remove(result42);
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
