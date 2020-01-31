﻿using System;
using System.Collections.Generic;

namespace Pizza_Data.Models
{
    public partial class Locations
    {
        public Locations()
        {
            Records = new HashSet<Records>();
        }

        public int Id { get; set; }
        public string Locat { get; set; }

        public virtual ICollection<Records> Records { get; set; }
    }
}
