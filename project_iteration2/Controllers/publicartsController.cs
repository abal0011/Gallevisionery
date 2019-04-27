using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using project_iteration2.Models;
using PagedList;

namespace project_iteration2.Controllers
{
    public class publicartsController : Controller
    {
        private publicartv1 db = new publicartv1();

        public ActionResult compare(string option1, string option2)
        {
            var option1Lst = new List<string>();
            var option1Qry = from o in db.publicarts orderby o.Gallery_Name select o.Gallery_Name;
            option1Lst.AddRange(option1Qry.Distinct());
            ViewBag.option1 = new SelectList(option1Lst);
            var option2Lst = new List<string>();
            var option2Qry = from p in db.publicarts orderby p.Gallery_Name select p.Gallery_Name;
            option2Lst.AddRange(option2Qry.Distinct());
            ViewBag.option2 = new SelectList(option2Lst);
            var options = from m in db.publicarts select m;
            
            if (!string.IsNullOrEmpty(option1) && !string.IsNullOrEmpty(option2))
            {
                options = options.Where(x => x.Gallery_Name == option1 || x.Gallery_Name == option2);
            }

            //if (!string.IsNullOrEmpty(option2))
            //{
            //    options = options.Where(y => y.Gallery_Name == option2);
            //}
            System.Diagnostics.Debug.WriteLine(options.ToList().Count);
            return View(options.ToList());
        }
        // GET: publicarts
        public ViewResult Index(string sortOrder,int? page, string currentFilter, bool? toilet, bool? install, bool? visual, bool? perf,bool? photography, bool? sculpture, bool? painting,string GallType ,string street , string searchString)
        {
            
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Gallery_Name" : "";
            ViewBag.CurrentSort = sortOrder;
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;


            var dropDownType = new List<string>();
            var dropDownTypeQry = from t in db.publicarts
                orderby t.Gallery_Type
                select t.Gallery_Type;
            dropDownType.AddRange(dropDownTypeQry.Distinct());
            ViewBag.GallType = new SelectList(dropDownType);
            var dropDownListStreet = new List<string>();
            var streetQry = from d in db.publicarts orderby d.Street select d.Street;
            dropDownListStreet.AddRange(streetQry.Distinct());
            ViewBag.street = new SelectList(dropDownListStreet);
            var publictemp = from s in db.publicarts
                select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                publictemp = publictemp.Where(s => s.Gallery_Name.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(street))
            {
                publictemp = publictemp.Where(x => x.Street == street);
            }
            if (!string.IsNullOrEmpty(GallType))
            {
                publictemp = publictemp.Where(x => x.Gallery_Type == GallType);
            }

            if (sculpture == true)

            {
                publictemp = publictemp.Where(s => s.Sculpture.Contains("Y"));
            }
            if (photography == true)

            {
                publictemp = publictemp.Where(s => s.Photography.Contains("Y"));
            }

            if (perf == true)
            {
                publictemp = publictemp.Where(s => s.Performance.Contains("Y"));
            }

            if ( painting == true)
            {
                publictemp = publictemp.Where(s => s.Painting.Contains("Y"));
            }
            if (install == true)
            {
                publictemp = publictemp.Where(s => s.Installation.Contains("Y"));
            }
            if (visual == true)
            {
                publictemp = publictemp.Where(s => s.Visual.Contains("Y"));
            }
            if (toilet == true)
            {
                publictemp = publictemp.Where(s => s.Unisex.Contains("Y"));
            }

            switch (sortOrder)
            {
                default:
                    publictemp = publictemp.OrderBy(s => s.Gallery_Name);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);



            return View(publictemp.ToPagedList(pageNumber, pageSize));
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
        public ActionResult Edit([Bind(Include = "Id,Gallery_Name,Latitude,Longitude,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,Opening,Painting,Sculpture,Photography,Installation,Performance,Visual,Unisex,Toilet_,Gallery_Type,Description,Website,Street,NoOFCF,NoOfBsn,NoOfArt, MonPed, TuesPed, WedPed, ThursPed, FriPed, SatPed, SunPed, Parking,MonPed2,TuesPed2,WedPed2,ThursPed2,FriPed2,SatPed2,SunPed2,MonPed3,TuesPed3,WedPed3,ThursPed3,FriPed3,SatPed3,SunPed3")] publicart publicart)
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
