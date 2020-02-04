using Pizza_Data.Methods;
using Pizza_Data.Models;
using System;
using Xunit;

namespace XUnitTestPizza
{
    public class PizzaTesting
    {
        private readonly Customer cus = new Customer();
        private readonly Employee emp = new Employee();
        private readonly Records rec = new Records();
        [Fact]
        public void Name_NonEmptyValue_StoresCorrectly() // customer
        {
            string name = "John";
            cus.Fname = name;
            Assert.Equal(name, cus.Fname);
        }

        [Fact]
        public void Username_NonEmptyValue_StoresCorrectly() // employee
        {
            string uname = "lsk123";
            emp.Uname = uname;
            Assert.Equal(uname, emp.Uname);
        }

        [Fact]
        public void Record_NonEmptyValue_StoresCorrectly() // records
        {
            string size = "large";
            rec.Size = size;
            Assert.Equal(size, rec.Size);
        }

        /*
        [Fact]
        public void checkDates24() // checks if DateTimeChecks methods are working properly
        {
            //Both dates should be less than a day from each other and return true

            DateTime now = new DateTime();
            Assert.True(DateTimeCheck.checkDTest(now));
        }

        [Fact]
        public void checkDates2hour() // checks if DateTimeChecks methods are working properly
        {
            //Both dates should be less than 2 hours from each other and return true

            DateTime now = new DateTime();
            Assert.True(DateTimeCheck.check2hourTest(now));
        }

        
        [Fact]
        public void checkCost() // checks if order cost returns properly
        {
            Calculate cal = new Calculate();
            int amount = 1;
            string pizzaSize = "large";
            string pizzaType = "Meat Lovers";

            double cost = (12.99 * 0.0825) + 12.99;
            cost = Math.Round((Double)cost, 2);


            Assert.Equal(cost, cal.calculateCostPreset(amount, pizzaSize, pizzaType));
        }
        */


    }
}
