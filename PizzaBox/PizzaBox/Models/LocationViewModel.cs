using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Models
{
    public class LocationViewModel
    {
        [Display(Name = "Location Id")]
        public int Id { get; set; }
        [Display(Name = "Location Address")]
        public string Locat { get; set; }
    }
}
