using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza_Data;
using Pizza_Data.Models;
using Pizza_Data.Repository;
using PizzaBox.Models;

namespace PizzaBox.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Location()
        {
            Entity db = new Entity();
            var location = Repository.GetLocations(db);

            ViewData["Location"] = location.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Location(LocationViewModel loc)
        {
            Entity db = new Entity();
            var location = Repository.GetLocations(db);

            foreach (var loca in location)
            {
                if(loc.Id == loca.Id)
                {
                    loc.Locat = loca.Locat;
                }
            }
            LocationHold.Id = loc.Id;
            LocationHold.Locat = loc.Locat;

            return RedirectToAction("Options", "Options");
        }



        public ActionResult EmpLocation()
        {
            Entity db = new Entity();
            var location = Repository.GetLocations(db);

            ViewData["Location"] = location.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpLocation(LocationViewModel loc)
        {
            Entity db = new Entity();
            var location = Repository.GetLocations(db);

            foreach (var loca in location)
            {
                if (loc.Id == loca.Id)
                {
                    loc.Locat = loca.Locat;
                }
            }
            LocationHold.Id = loc.Id;
            LocationHold.Locat = loc.Locat;

            return RedirectToAction("StoreRecords", "Records");
        }


        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Location/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}