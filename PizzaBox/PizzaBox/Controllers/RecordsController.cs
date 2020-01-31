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
using Pizza_Data.Methods;

namespace PizzaBox.Controllers
{
    public class RecordsController : Controller
    {
        // GET: Records
        public ActionResult Index()
        {
            Entity db = new Entity();
            var records = Repository.GetRecordsReverse(db);

            List<RecordsViewModel> rvm = new List<RecordsViewModel>();
            foreach (var item in records)
            {
                RecordsViewModel rec = new RecordsViewModel();
                rec.Id = item.Id;
                rec.LocatId = item.LocatId;
                rec.UserId = item.UserId;
                rec.Total = item.Total;
                rec.DateT = item.DateT;
                rec.AmountP = item.AmountP;
                rec.PizzaType = item.PizzaType;
                rec.Size = item.Size;
                rec.Crust = item.Crust;
                rvm.Add(rec);

            }

            return View(rvm);
        }



        public ActionResult UserRecords()
        {
            Entity db = new Entity();
            var record = Repository.GetRecordsReverse(db);

            List<UserRecordsModel> rvm = new List<UserRecordsModel>();
            foreach (var item in record)
            {
                if(PCustomer.Id == item.UserId)
                {
                    string currentLoc;
                    FindLocation find = new FindLocation();
                    currentLoc = find.returnLocation(item.LocatId);

                    UserRecordsModel rec = new UserRecordsModel();
                    rec.Total = item.Total;
                    rec.DateT = item.DateT;
                    rec.AmountP = item.AmountP;
                    rec.PizzaType = item.PizzaType;
                    rec.Size = item.Size;
                    rec.Crust = item.Crust;
                    rec.LocationAdd = currentLoc;

                    rvm.Add(rec);
                }

            }

            return View(rvm);
        }

        public ActionResult StoreRecords()
        {
            Entity db = new Entity();
            var record = Repository.GetRecordsReverse(db);

            List<StoreRecordsModel> rvm = new List<StoreRecordsModel>();
            foreach (var item in record)
            {
                if (LocationHold.Id == item.LocatId)
                {                  
                    StoreRecordsModel rec = new StoreRecordsModel();
                    rec.UserId = item.UserId;
                    rec.Total = item.Total;
                    rec.DateT = item.DateT;
                    rec.AmountP = item.AmountP;
                    rec.PizzaType = item.PizzaType;
                    rec.Size = item.Size;
                    rec.Crust = item.Crust;

                    rvm.Add(rec);
                }

            }

            return View(rvm);
        }

        // GET: Records/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Records/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Records/Create
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

        // GET: Records/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Records/Edit/5
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

        // GET: Records/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Records/Delete/5
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