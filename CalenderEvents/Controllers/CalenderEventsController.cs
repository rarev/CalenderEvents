using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CalenderEvents.Models;

namespace CalenderEvents.Controllers
{
    public class CalenderEventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CalenderEvents
        public ActionResult Index()
        {
            return View(db.CalenderEvents.ToList());
        }

        // GET: CalenderEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalenderEvent calenderEvent = db.CalenderEvents.Find(id);
            if (calenderEvent == null)
            {
                return HttpNotFound();
            }
            return View(calenderEvent);
        }

        // GET: CalenderEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalenderEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventID,Title,StartDate,EndDate,StartTime,EndTime,Category,Description")] CalenderEvent calenderEvent)
        {
            if (ModelState.IsValid)
            {
                db.CalenderEvents.Add(calenderEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calenderEvent);
        }

        // GET: CalenderEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalenderEvent calenderEvent = db.CalenderEvents.Find(id);
            if (calenderEvent == null)
            {
                return HttpNotFound();
            }
            return View(calenderEvent);
        }

        // POST: CalenderEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventID,Title,StartDate,EndDate,StartTime,EndTime,Category,Description")] CalenderEvent calenderEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calenderEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calenderEvent);
        }

        // GET: CalenderEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalenderEvent calenderEvent = db.CalenderEvents.Find(id);
            if (calenderEvent == null)
            {
                return HttpNotFound();
            }
            return View(calenderEvent);
        }

        // POST: CalenderEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalenderEvent calenderEvent = db.CalenderEvents.Find(id);
            db.CalenderEvents.Remove(calenderEvent);
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
