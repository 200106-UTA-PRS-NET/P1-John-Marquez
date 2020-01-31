using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLib
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string PizzaType { get; set; }
        public decimal Large { get; set; }
        public decimal Med { get; set; }
        public decimal Small { get; set; }
    }
}
