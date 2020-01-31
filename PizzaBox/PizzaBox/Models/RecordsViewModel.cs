using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Models
{
    public class RecordsViewModel
    {

        [Display(Name = "Order Id")]
        public int Id { get; set; }

        [Display(Name = "Location Id")]
        public int LocatId { get; set; }

        [Display(Name = "User Id")]
        public int UserId { get; set; }

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
    }
}
