using System;
using System.Collections.Generic;

namespace Pizza_Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Records = new HashSet<Records>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Uname { get; set; }
        public string Pword { get; set; }

        public virtual ICollection<Records> Records { get; set; }
    }
}
