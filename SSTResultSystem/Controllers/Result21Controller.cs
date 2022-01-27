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
    public class Result21Controller : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();

        // GET: Result21
        public ActionResult Index()
        {
            return View(db.result21.ToList());
        }

        // GET: Result21/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result21 result21 = db.result21.Find(id);
            if (result21 == null)
            {
                return HttpNotFound();
            }
            return View(result21);
        }

        // GET: Result21/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result21/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studentid,examterm,mat2131,che2122,cse2133,cse2134,cse2135,cse21p6,cse2137,cse21p8")] result21 result21)
        {
            if (ModelState.IsValid)
            {
                db.result21.Add(result21);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result21);
        }

        // GET: Result21/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result21 result21 = db.result21.Find(id);
            if (result21 == null)
            {
                return HttpNotFound();
            }
            return View(result21);
        }

        // POST: Result21/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studentid,examterm,mat2131,che2122,cse2133,cse2134,cse2135,cse21p6,cse2137,cse21p8")] result21 result21)
        {
            if (ModelState.IsValid)
            {
                db.Entry(result21).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(result21);
        }

        // GET: Result21/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result21 result21 = db.result21.Find(id);
            if (result21 == null)
            {
                return HttpNotFound();
            }
            return View(result21);
        }

        // POST: Result21/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            result21 result21 = db.result21.Find(id);
            db.result21.Remove(result21);
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
