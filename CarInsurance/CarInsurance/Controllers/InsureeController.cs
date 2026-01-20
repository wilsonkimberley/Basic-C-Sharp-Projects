using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Insuree insuree = db.Insurees.Find(id);

            if (insuree == null)
                return HttpNotFound();

            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50m;

                // AGE CALCULATION
                DateTime today = DateTime.Today;
                int age = today.Year - insuree.DateOfBirth.Year;

                if (insuree.DateOfBirth > today.AddYears(-age))
                    age--;

                if (age <= 18)
                    quote += 100m;
                else if (age <= 25)
                    quote += 50m;
                else
                    quote += 25m;

                // CAR YEAR (nullable)
                if (insuree.CarYear.HasValue)
                {
                    if (insuree.CarYear < 2000)
                        quote += 25m;

                    if (insuree.CarYear > 2015)
                        quote += 25m;
                }

                // CAR MAKE / MODEL
                if (!string.IsNullOrEmpty(insuree.CarMake) &&
                    insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25m;

                    if (!string.IsNullOrEmpty(insuree.CarModel) &&
                        insuree.CarModel.ToLower() == "911 carrera")
                    {
                        quote += 25m;
                    }
                }

                // SPEEDING TICKETS (nullable)
                if (insuree.SpeedingTickets.HasValue)
                {
                    quote += insuree.SpeedingTickets.Value * 10m;
                }

                // DUI (nullable bool)
                if (insuree.DUI.HasValue && insuree.DUI.Value)
                {
                    quote *= 1.25m;
                }

                // COVERAGE TYPE (nullable bool)
                if (insuree.CoverageType.HasValue && insuree.CoverageType.Value)
                {
                    quote *= 1.5m;
                }

                insuree.Quote = Math.Round(quote, 2);

                db.Insurees.Add(insuree);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Insuree insuree = db.Insurees.Find(id);

            if (insuree == null)
                return HttpNotFound();

            return View(insuree);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Insuree insuree = db.Insurees.Find(id);

            if (insuree == null)
                return HttpNotFound();

            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // ADMIN VIEW
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }
    }
}
