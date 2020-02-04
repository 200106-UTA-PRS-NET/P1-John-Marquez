using System.ComponentModel.DataAnnotations;

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
