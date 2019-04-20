using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using project_iteration2.Models;

namespace project_iteration2.Controllers
{
    public class publicartsController : Controller
    {
        private publicartv1 db = new publicartv1();

        // GET: publicarts
        public ActionResult Index()
        {
            return View(db.publicarts.ToList());
        }

        // GET: publicarts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            publicart publicart = db.publicarts.Find(id);
            if (publicart == null)
            {
                return HttpNotFound();
            }
            return View(publicart);
        }

        // GET: publicarts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: publicarts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Gallery_Name,Latitude,Longitude,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,Opening,Painting,Sculpture,Photography,Installation,Performance,Visual,Unisex,Toilet_,Gallery_Type,Description,Website,Street")] publicart publicart)
        {
            if (ModelState.IsValid)
            {
                db.publicarts.Add(publicart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publicart);
        }

        // GET: publicarts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            publicart publicart = db.publicarts.Find(id);
            if (publicart == null)
            {
                return HttpNotFound();
            }
            return View(publicart);
        }

        // POST: publicarts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Gallery_Name,Latitude,Longitude,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,Opening,Painting,Sculpture,Photography,Installation,Performance,Visual,Unisex,Toilet_,Gallery_Type,Description,Website,Street")] publicart publicart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publicart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicart);
        }

        // GET: publicarts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            publicart publicart = db.publicarts.Find(id);
            if (publicart == null)
            {
                return HttpNotFound();
            }
            return View(publicart);
        }

        // POST: publicarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            publicart publicart = db.publicarts.Find(id);
            db.publicarts.Remove(publicart);
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
