﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Models
{
    public class UserRecordsModel
    {
        [Display(Name = "Total Cost")]
        public decimal Total { get; set; }

        [Display(Name = "Date/Time")]
        public DateTime DateT { get; set; }

        [Display(Name = "Amount of Pizzas")]
        public int AmountP { get; set; }

        [Display(Name = "Type of Pizza")]
        public string PizzaType { get; set; }

        [Display(Name = "Size of Pizza")]
        public string Size { get; set; }

        [Display(Name = "Size of Crust")]
        public string Crust { get; set; }

        [Display(Name = "Location Adress")]
        public string LocationAdd { get; set; }
    }
}
