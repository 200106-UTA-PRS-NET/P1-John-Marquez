using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Models
{
    public class OrderModel
    {

        public List<string> Pizzas { get; set; }
        public List<decimal> Large { get; set; }
        public List<decimal> Med { get; set; }
        public List<decimal> Small { get; set; }



        [Required(ErrorMessage = "Amount of Pizzas are a required input")]
        [Range(1, 99)]
        public int AmountP { get; set; }

        [Required(ErrorMessage = "Type of pizza is a required input")]
        public string PizzaType { get; set; }

        [Required(ErrorMessage = "Size is a required input")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Crust is a required input")]
        public string Crust { get; set; }

    }
}
