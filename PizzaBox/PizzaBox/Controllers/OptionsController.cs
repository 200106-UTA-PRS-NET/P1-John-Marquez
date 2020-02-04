using System;
using Microsoft.AspNetCore.Mvc;
using Pizza_Data.Methods;

namespace PizzaBox.Controllers
{
    public class OptionsController : Controller
    {
        public ActionResult Options()
        {
            if (DateTimeCheck.checkDT() == false)
            {
                ViewBag.Message = String.Format("Must Wait 24 hours before next purchace at this location!");
                return View();
            }
            else if (DateTimeCheck.check2hour() == false)
            {
                ViewBag.Message = String.Format("Must Wait 2 hours before next purchace at any store!");
                return View();
            }

            return View();
        }


    }
}