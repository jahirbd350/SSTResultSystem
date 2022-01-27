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
    public class Result12Controller : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();

        // GET: Result12
        public ActionResult Index()
        {
            return View(db.result12.ToList());
        }

        // GET: Result12/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result12 result12 = db.result12.Find(id);
            if (result12 == null)
            {
                return HttpNotFound();
            }
            return View(result12);
        }

        // GET: Result12/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result12/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studentid,examterm,mat1231,hum1222,eee1233,eee12p4,cse1235,cse12p6,cse1237,cse12p8")] result12 result12)
        {
            if (ModelState.IsValid)
            {
                db.result12.Add(result12);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result12);
        }

        // GET: Result12/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result12 result12 = db.result12.Find(id);
            if (result12 == null)
            {
                return HttpNotFound();
            }
            return View(result12);
        }

        // POST: Result12/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studentid,examterm,mat1231,hum1222,eee1233,eee12p4,cse1235,cse12p6,cse1237,cse12p8")] result12 result12)
        {
            if (ModelState.IsValid)
            {
                db.Entry(result12).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(result12);
        }

        // GET: Result12/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result12 result12 = db.result12.Find(id);
            if (result12 == null)
            {
                return HttpNotFound();
            }
            return View(result12);
        }

        // POST: Result12/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            result12 result12 = db.result12.Find(id);
            db.result12.Remove(result12);
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
