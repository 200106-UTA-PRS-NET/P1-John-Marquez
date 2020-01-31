using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza_Data.Models;
using Pizza_Data.Repository;
using PizzaBox.Models;

namespace PizzaBox.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register/Create
        public ActionResult CreateAccount()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAccount(RegisterViewModel reg)
        {
            Entity db = new Entity();
            var customer = Repository.GetCustomer(db);

            foreach (var cus in customer) // run though employees table and will check if user is in program
            {
                if (cus.Uname == reg.UserName)
                {
                    ViewBag.Message = String.Format($"Invalid Input, Username '{reg.UserName}' already exists!");
                    return View();
                }
            }           
            Customer cust = new Customer()
            {
                Fname = reg.FirstName,
                Lname = reg.LastName,
                Uname = reg.UserName,
                Pword = reg.Password,
            };
            Repository.AddCustomer(db, cust);
            ViewBag.Message = String.Format("Success! Your account has been created!");
            return View();

        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
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

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
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