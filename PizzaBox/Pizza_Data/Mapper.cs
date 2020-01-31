using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Data
{
    public class Mapper
    {
        public static PizzaLib.Employee Map(Pizza_Data.Models.Employee employee)
        {
            return new PizzaLib.Employee()
            {
                Id = employee.Id,
                Fname = employee.Fname,
                Lname = employee.Lname,
                Uname = employee.Uname,
                Pword = employee.Pword,
            };
        }
        public static Pizza_Data.Models.Employee Map(PizzaLib.Employee employee)
        {
            return new Pizza_Data.Models.Employee()
            {
                Id = employee.Id,
                Fname = employee.Fname,
                Lname = employee.Lname,
                Uname = employee.Uname,
                Pword = employee.Pword,

            };
        }

        public static PizzaLib.Customer Map(Pizza_Data.Models.Customer customer)
        {
            return new PizzaLib.Customer()
            {
                Id = customer.Id,
                Fname = customer.Fname,
                Lname = customer.Lname,
                Uname = customer.Uname,
                Pword = customer.Pword,
            };
        }
        public static Pizza_Data.Models.Customer Map(PizzaLib.Customer customer)
        {
            return new Pizza_Data.Models.Customer()
            {
                Id = customer.Id,
                Fname = customer.Fname,
                Lname = customer.Lname,
                Uname = customer.Uname,
                Pword = customer.Pword,

            };
        }

        public static PizzaLib.Locations Map(Pizza_Data.Models.Locations location)
        {
            return new PizzaLib.Locations()
            {
                Id = location.Id,
                Locat = location.Locat

            };
        }
        public static Pizza_Data.Models.Locations Map(PizzaLib.Locations location)
        {
            return new Pizza_Data.Models.Locations()
            {
                Id = location.Id,
                Locat = location.Locat

            };
        }

        public static PizzaLib.Records Map(Pizza_Data.Models.Records records)
        {
            return new PizzaLib.Records()
            {
                Id = records.Id,
                LocatId = records.LocatId,
                UserId = records.UserId,
                Total = records.Total,
                DateT = records.DateT,
                AmountP = records.AmountP,
                PizzaType = records.PizzaType,
                Size = records.Size,
                Crust = records.Crust

            };
        }

        public static Pizza_Data.Models.Records Map(PizzaLib.Records records)
        {
            return new Pizza_Data.Models.Records()
            {
                Id = records.Id,
                LocatId = records.LocatId,
                UserId = records.UserId,
                Total = records.Total,
                DateT = records.DateT,
                AmountP = records.AmountP,
                PizzaType = records.PizzaType,
                Size = records.Size,
                Crust = records.Crust

            };
        }

        public static PizzaLib.Pizza Map(Pizza_Data.Models.Pizza pizza)
        {
            return new PizzaLib.Pizza()
            {
                Id = pizza.Id,
                PizzaType = pizza.PizzaType,
                Small = pizza.Small,
                Med = pizza.Small,
                Large = pizza.Large

            };
        }

        public static Pizza_Data.Models.Pizza Map(PizzaLib.Pizza pizza)
        {
            return new Pizza_Data.Models.Pizza()
            {
                Id = pizza.Id,
                PizzaType = pizza.PizzaType,
                Small = pizza.Small,
                Med = pizza.Small,
                Large = pizza.Large
            };

        }
    }
}
