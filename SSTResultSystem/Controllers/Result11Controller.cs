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
    public class Result11Controller : Controller
    {
        private SSTResultSystemEntities db = new SSTResultSystemEntities();

        // GET: Result11
        
        public ActionResult Index()
        {
            return View(db.result11.ToList());
        }
        
        public ActionResult SemResult(string examterm)
        {
            return View(db.result11.Where(x => x.examterm == examterm).ToList());
        }

        // GET: Result11/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result11 result11 = db.result11.Find(id);
            if (result11 == null)
            {
                return HttpNotFound();
            }
            return View(result11);
        }

        // GET: Result11/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result11/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studentid,examterm,eng1131,phy1132,bus1123,mat1134,eee1135,eee11p6,cse1127,cse11p8")] result11 result11)
        {
            if (ModelState.IsValid)
            {
                db.result11.Add(result11);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(result11);
        }

        // GET: Result11/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result11 result11 = db.result11.Find(id);
            if (result11 == null)
            {
                return HttpNotFound();
            }
            return View(result11);
        }

        // POST: Result11/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studentid,examterm,eng1131,phy1132,bus1123,mat1134,eee1135,eee11p6,cse1127,cse11p8")] result11 result11)
        {
            if (ModelState.IsValid)
            {
                db.Entry(result11).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(result11);
        }

        // GET: Result11/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result11 result11 = db.result11.Find(id);
            if (result11 == null)
            {
                return HttpNotFound();
            }
            return View(result11);
        }

        // POST: Result11/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            result11 result11 = db.result11.Find(id);
            db.result11.Remove(result11);
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
