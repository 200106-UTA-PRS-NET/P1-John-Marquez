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
    public class LoginController : Controller
    {
        // GET: Login
        
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult EmpLogin()
        {
            return View();
        }



        // POST: Login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel user)
        {

            Entity db = new Entity();
            var customer = Repository.GetCustomer(db);

            foreach (var cus in customer) // run though employees table and will check if user is in program
            {
                if (cus.Uname == user.UserName && cus.Pword == user.Password) // stores user information for future reference
                {
                   
                    PCustomer.Id = cus.Id;
                    PCustomer.firstname = cus.Fname;

                    return RedirectToAction("Location", "Location");
                }
            }
            ViewBag.Message = String.Format("Incorrect Username or Password!");
            return View();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpLogin(LoginModel user)
        {

            Entity db = new Entity();
            var employees = Repository.GetEmployees(db);

            foreach (var emp in employees) // run though employees table and will check if user is in program
            {
                if (emp.Uname == user.UserName && emp.Pword == user.Password) // stores user information for future reference
                {
                    PEmployee.Id = emp.Id;
                    PEmployee.firstname = emp.Fname;
                    return RedirectToAction("EmpLocation", "Location");
                }
            }
            ViewBag.Message = String.Format("Incorrect Username or Password!");
            return View();

        }

    }
}