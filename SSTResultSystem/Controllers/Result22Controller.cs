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
    public class Result22Controller : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();

        // GET: Result22
        public ActionResult Index()
        {
            return View(db.result22.ToList());
        }

        // GET: Result22/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result22 result22 = db.result22.Find(id);
            if (result22 == null)
            {
                return HttpNotFound();
            }
            return View(result22);
        }

        // GET: Result22/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result22/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studentid,examterm,eco2221,cse2232,cse22p3,cse2234,cse22p5,cse2236,cse22p7,cse2238,cse22p9")] result22 result22)
        {
            if (ModelState.IsValid)
            {
                db.result22.Add(result22);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result22);
        }

        // GET: Result22/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result22 result22 = db.result22.Find(id);
            if (result22 == null)
            {
                return HttpNotFound();
            }
            return View(result22);
        }

        // POST: Result22/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studentid,examterm,eco2221,cse2232,cse22p3,cse2234,cse22p5,cse2236,cse22p7,cse2238,cse22p9")] result22 result22)
        {
            if (ModelState.IsValid)
            {
                db.Entry(result22).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(result22);
        }

        // GET: Result22/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result22 result22 = db.result22.Find(id);
            if (result22 == null)
            {
                return HttpNotFound();
            }
            return View(result22);
        }

        // POST: Result22/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            result22 result22 = db.result22.Find(id);
            db.result22.Remove(result22);
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
