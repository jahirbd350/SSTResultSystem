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
    public class Result31Controller : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();

        // GET: Result31
        public ActionResult Index()
        {
            return View(db.result31.ToList());
        }

        // GET: Result31/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result31 result31 = db.result31.Find(id);
            if (result31 == null)
            {
                return HttpNotFound();
            }
            return View(result31);
        }

        // GET: Result31/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result31/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studentid,examterm,mat3131,cse3122,cse3133,cse3134,cse31p5,cse3136,cse31p7,cse31p8,cse31p9")] result31 result31)
        {
            if (ModelState.IsValid)
            {
                db.result31.Add(result31);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result31);
        }

        // GET: Result31/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result31 result31 = db.result31.Find(id);
            if (result31 == null)
            {
                return HttpNotFound();
            }
            return View(result31);
        }

        // POST: Result31/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studentid,examterm,mat3131,cse3122,cse3133,cse3134,cse31p5,cse3136,cse31p7,cse31p8,cse31p9")] result31 result31)
        {
            if (ModelState.IsValid)
            {
                db.Entry(result31).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(result31);
        }

        // GET: Result31/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result31 result31 = db.result31.Find(id);
            if (result31 == null)
            {
                return HttpNotFound();
            }
            return View(result31);
        }

        // POST: Result31/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            result31 result31 = db.result31.Find(id);
            db.result31.Remove(result31);
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
