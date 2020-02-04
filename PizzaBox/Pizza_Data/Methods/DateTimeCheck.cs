using Pizza_Data.Models;
using System;

namespace Pizza_Data.Methods
{ 
    static public class DateTimeCheck
    {       
        static public bool checkDT() //checks if last order meets time and date conditions for current order
        {
            DateTime now = DateTime.Now;

            Entity db = new Entity();
            
            var records = Repository.Repository.GetRecordsReverse(db);
            foreach (var rec in records) 
            {
                if(rec.UserId == PCustomer.Id && rec.LocatId == LocationHold.Id)
                { 
                    TimeSpan interval = now - rec.DateT; // Timespan struct to calculate the interval between the two dates.                                                         

                    if (interval.TotalDays < 1) // If totaldays less than 1, does not allow purchace
                    {
                        return false;
                    }
                    
                }
            }            
            return true;
        }

        static public bool checkDTest(DateTime date) //used for unit test
        {
            DateTime now = DateTime.Now;

            TimeSpan interval = now - date; // Timespan struct to calculate the interval between the two dates.                                                         

            if (interval.TotalDays < 1) // If totaldays less than 1, does not allow purchace
            {
                return false;
            }
            return true;
        }

        static public bool check2hour() //checks if last order meets time and date conditions for current order
        {
            DateTime now = DateTime.Now;

            Entity db = new Entity();

            var records = Repository.Repository.GetRecordsReverse(db);
            foreach (var rec in records)
            {                              
                if (rec.UserId == PCustomer.Id)
                {
                    TimeSpan interval = now - rec.DateT; // Timespan struct to calculate the interval between the two dates.                                                         

                    if (interval.TotalHours < 2) // If totalhours less than 2, does not allow purchace
                    {
                        //Console.WriteLine("Must wait 2 hours before next purchase in general");
                        //Console.WriteLine($"Last order on {rec.DateT}");
                        return false;
                    }
                }
                
            }
            return true;
        }

        static public bool check2hourTest(DateTime date) //used for unit testing
        {
            DateTime now = DateTime.Now;

            TimeSpan interval = now - date; // Timespan struct to calculate the interval between the two dates.                                                         

            if (interval.TotalHours < 2) // If totalhours less than 2, does not allow purchace
            {
                return false;
            }
            return true;
        }
    }
}