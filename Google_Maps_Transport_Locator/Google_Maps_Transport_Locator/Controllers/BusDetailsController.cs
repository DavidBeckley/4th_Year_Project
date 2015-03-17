using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Google_Maps_Transport_Locator.Models;

namespace Google_Maps_Transport_Locator.Controllers
{
    public class BusDetailsController : Controller
    {
        private BusDetailsContext db = new BusDetailsContext();

        // GET: BusDetails
        public ActionResult Index()
        {
            return View(db.details.ToList());
        }

        // GET: BusDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusDetails busDetails = db.details.Find(id);
            if (busDetails == null)
            {
                return HttpNotFound();
            }
            return View(busDetails);
        }

        // GET: BusDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,busNumber,busTowards,busVia,bStopNumber,busAddress,busStopLocation,latitude,longitude,heading")] BusDetails busDetails)
        {
            if (ModelState.IsValid)
            {
                db.details.Add(busDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(busDetails);
        }

        // GET: BusDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusDetails busDetails = db.details.Find(id);
            if (busDetails == null)
            {
                return HttpNotFound();
            }
            return View(busDetails);
        }

        // POST: BusDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,busNumber,busTowards,busVia,bStopNumber,busAddress,busStopLocation,latitude,longitude,heading")] BusDetails busDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(busDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(busDetails);
        }

        // GET: BusDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusDetails busDetails = db.details.Find(id);
            if (busDetails == null)
            {
                return HttpNotFound();
            }
            return View(busDetails);
        }

        // POST: BusDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusDetails busDetails = db.details.Find(id);
            db.details.Remove(busDetails);
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
