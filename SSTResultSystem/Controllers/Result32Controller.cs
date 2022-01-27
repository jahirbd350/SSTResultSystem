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
    public class Result32Controller : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();

        // GET: Result32
        public ActionResult Index()
        {
            return View(db.result32.ToList());
        }

        // GET: Result32/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result32 result32 = db.result32.Find(id);
            if (result32 == null)
            {
                return HttpNotFound();
            }
            return View(result32);
        }

        // GET: Result32/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result32/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studentid,examterm,cse3221,cse3232,cse3233,cse32p4,cse3235,cse32p6,cse3237,cse32p8,cse32p9")] result32 result32)
        {
            if (ModelState.IsValid)
            {
                db.result32.Add(result32);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result32);
        }

        // GET: Result32/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result32 result32 = db.result32.Find(id);
            if (result32 == null)
            {
                return HttpNotFound();
            }
            return View(result32);
        }

        // POST: Result32/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studentid,examterm,cse3221,cse3232,cse3233,cse32p4,cse3235,cse32p6,cse3237,cse32p8,cse32p9")] result32 result32)
        {
            if (ModelState.IsValid)
            {
                db.Entry(result32).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(result32);
        }

        // GET: Result32/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result32 result32 = db.result32.Find(id);
            if (result32 == null)
            {
                return HttpNotFound();
            }
            return View(result32);
        }

        // POST: Result32/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            result32 result32 = db.result32.Find(id);
            db.result32.Remove(result32);
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
