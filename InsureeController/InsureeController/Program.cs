using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using YourProjectNamespace.Models; // Adjust namespace

public class InsureeController : Controller
{
    private InsuranceEntities db = new InsuranceEntities(); // Your EF context

    // POST: Insuree/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,SpeedingTickets,DUI,FullCoverage")] Insuree insuree)
    {
        if (ModelState.IsValid)
        {
            // Start base quote
            decimal quote = 50m;

            // Age calculation
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
                age--;

            if (age <= 18)
                quote += 100;
            else if (age >= 19 && age <= 25)
                quote += 50;
            else if (age >= 26)
                quote += 25;

            // Car year
            if (insuree.CarYear < 2000)
                quote += 25;
            if (insuree.CarYear > 2015)
                quote += 25;

            // Car make & model
            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25;
                if (insuree.CarModel.ToLower() == "911 carrera")
                    quote += 25; // Additional 25 for 911 Carrera
            }

            // Speeding tickets
            quote += insuree.SpeedingTickets * 10;

            // DUI
            if (insuree.DUI)
                quote *= 1.25m;

            // Full coverage
            if (insuree.FullCoverage)
                quote *= 1.5m;

            // Save quote
            insuree.Quote = quote;

            db.Insurees.Add(insuree);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(insuree);
    }

    // Admin view
    public ActionResult Admin()
    {
        var insurees = db.Insurees.Select(i => new
        {
            i.FirstName,
            i.LastName,
            i.EmailAddress,
            i.Quote
        }).ToList();

        return View(insurees);
    }
}