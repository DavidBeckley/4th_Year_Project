using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Google_Maps_Transport_Project.Models;

namespace Google_Maps_Transport_Project.Controllers
{
    public class Bus_detailsController : Controller
    {
        private BusDetailsContext db = new BusDetailsContext();

        // GET: Bus_details
        public ActionResult Index()
        {
            return View(db.details.ToList());
        }

        // GET: Bus_details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus_details bus_details = db.details.Find(id);
            if (bus_details == null)
            {
                return HttpNotFound();
            }
            return View(bus_details);
        }

        // GET: Bus_details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bus_details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,busNumber,bStopNumber,busAddress,busStopLocation,latitude,longitude,heading")] Bus_details bus_details)
        {
            if (ModelState.IsValid)
            {
                db.details.Add(bus_details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bus_details);
        }

        // GET: Bus_details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus_details bus_details = db.details.Find(id);
            if (bus_details == null)
            {
                return HttpNotFound();
            }
            return View(bus_details);
        }

        // POST: Bus_details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,busNumber,bStopNumber,busAddress,busStopLocation,latitude,longitude,heading")] Bus_details bus_details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bus_details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bus_details);
        }

        // GET: Bus_details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus_details bus_details = db.details.Find(id);
            if (bus_details == null)
            {
                return HttpNotFound();
            }
            return View(bus_details);
        }

        // POST: Bus_details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bus_details bus_details = db.details.Find(id);
            db.details.Remove(bus_details);
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
