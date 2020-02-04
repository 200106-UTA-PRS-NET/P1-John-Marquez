using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pizza_Data;
using Pizza_Data.Methods;
using Pizza_Data.Models;
using Pizza_Data.Repository;
using PizzaBox.Models;

namespace PizzaBox.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewOrder()
        {
            List<ViewOrderModel> vom = new List<ViewOrderModel>();
            foreach (var piz in PizzasLt.PizzaList) //prints current order of user
            {
                ViewOrderModel ord = new ViewOrderModel();

                ord.amount = piz.Amount;
                ord.pizzaType = piz.PizzaType;
                ord.size = piz.Size;
                ord.crust = piz.Crust;
                ord.total = piz.Total;


                vom.Add(ord);
            }

            return View(vom);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClearOrder()
        {
            PizzasLt.PizzaList.Clear();
            TotalCost.Tot = 0;
            return RedirectToAction("ViewOrder", "Order");

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmOrder()
        {
            Entity db = new Entity();

            foreach (var piz in PizzasLt.PizzaList) // goes through the list of objects and stores them to the records table
            {
                decimal tot = Convert.ToDecimal(piz.Total);
                tot = Math.Round(tot, 2);
                DateTime dateTime = DateTime.Now;
                Records records = new Records()
                {
                    UserId = piz.UserID,
                    Total = tot,
                    DateT = dateTime,
                    AmountP = piz.Amount,
                    PizzaType = piz.PizzaType,
                    Size = piz.Size,
                    Crust = piz.Crust,
                    LocatId = LocationHold.Id
                };

                Repository.AddRecords(db, records);
            }
            PizzasLt.PizzaList.Clear();
            TotalCost.Tot = 0;
            return RedirectToAction("Options", "Options");

        }



        public ActionResult Order()
        {           
            if (DateTimeCheck.checkDT() == false)
            {
                return RedirectToAction("Options", "Options");
            }
            else if (DateTimeCheck.check2hour() == false)
            {
                return RedirectToAction("Options", "Options");                
            }

            Entity db = new Entity();
            var pizza = Repository.GetPizza(db);

            ViewData["Pizza"] = pizza.ToList();

            return View();

        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Order(OrderModel order)
        {
            Entity db = new Entity();
            var pizza = Repository.GetPizza(db);
            Calculate cal = new Calculate();
            double currentTotal = cal.calculateCostPreset(order.AmountP, order.Size, order.PizzaType);

            TotalCost.Tot +=  currentTotal;
               
            if(TotalCost.Tot > 250)
            {
                ViewBag.Message = String.Format("Cannot Order more than $250! Order Reset");
                ViewData["Pizza"] = pizza.ToList();
                PizzasLt.PizzaList.Clear();
                TotalCost.Tot = 0;

                return View();
            }

            PizzasLt.PizzaList.Add(new Pizzas(PCustomer.Id, currentTotal, order.AmountP, order.PizzaType, order.Size, order.Crust));

            ViewData["Pizza"] = pizza.ToList();

            ViewBag.Message = String.Format("Order has been added!");

            return View();

        }

    }
}