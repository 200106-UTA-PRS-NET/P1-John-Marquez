﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza_Data;
using PizzaBox.Models;

namespace PizzaBox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LocationHold.Id = 0;
            LocationHold.Locat = "";

            TotalCost.Tot = 0;
            PEmployee.Id = 0;
            PCustomer.Id = 0;

            PEmployee.Uname = "";
            PCustomer.Uname = "";

            PEmployee.firstname = "";
            PCustomer.firstname = "";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
