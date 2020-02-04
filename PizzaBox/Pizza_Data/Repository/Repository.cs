using Pizza_Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Data.Repository
{
    public static class Repository
    {

        //Getting Repository
        public static IEnumerable<PizzaLib.Employee> GetEmployees(Entity db) // creates query to gather total employee table information
        {
            var query = from e in db.Employee
                        //select e;
                        select Mapper.Map(e); // set to mapper


            return query;
        }

        public static IEnumerable<PizzaLib.Customer> GetCustomer(Entity db) // creates query to gather total customer table information
        {
            var query = from e in db.Customer
                        //select e;
                        select Mapper.Map(e); // set to mapper

            return query;
        }



        public static IEnumerable<PizzaLib.Pizza> GetPizza(Entity db)  // creates query to gather total pizza table information
        {
            var query = from e in db.Pizza
                        //select e;
                        select Mapper.Map(e); // set to mapper


            return query;
        }

        public static IEnumerable<PizzaLib.Records> GetRecords(Entity db)  // creates query to gather total records table information
        {
            var query = from e in db.Records
                        //select e;
                        select Mapper.Map(e); // set to mapper

            return query;
        }

        public static IEnumerable<PizzaLib.Locations> GetLocations(Entity db)  // creates query to gather total location table information
        {
            var query = from e in db.Locations
                        //select e;
                        select Mapper.Map(e); // set to mapper

            return query;
        }

        public static IEnumerable<PizzaLib.Records> GetRecordsReverse(Entity db)  // creates query to gather total records table information
        {                                                                // in reverse based on date and time
            var query = from e in db.Records
                        orderby e.DateT descending
                        //select e;
                        select Mapper.Map(e); // set to mapper

            return query;
        }


        // Adding Repositories
        public static void AddCustomer(Entity db, Customer customer)
        {
            db.Customer.Add(customer);// this will generate insert query for customers
            db.SaveChanges();// this will execute the above generate insert query
        }

        public static void AddRecords(Entity db, Records records)
        {
            db.Records.Add(records);// this will generate insert query for records
            db.SaveChanges();// this will execute the above generate insert query
        }


    }

}
