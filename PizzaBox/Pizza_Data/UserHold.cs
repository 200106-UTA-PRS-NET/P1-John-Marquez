﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Data
{
    static public class PEmployee // holds the current employee info for futuer reference
    {
        static public int Id { get; set; }
        static public string Uname { get; set; }
        static public string firstname { get; set; }
    }

    static public class PCustomer // holds the current customer info for future reference
    {
        static public int Id { get; set; }
        static public string Uname { get; set; }
        static public string firstname { get; set; }
    }
}
