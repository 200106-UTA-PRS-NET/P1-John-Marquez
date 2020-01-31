using Pizza_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Models
{
    public class ViewOrderModel
    {
        public double total { get; set; }
        public int amount { get; set; }
        public string pizzaType { get; set; }
        public string size { get; set; }
        public string crust { get; set; }
    }
}
