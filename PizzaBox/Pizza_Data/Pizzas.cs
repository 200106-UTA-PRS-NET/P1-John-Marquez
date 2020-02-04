﻿
namespace Pizza_Data
{

    public class Pizzas //object that holds pizza information and user who made it for specific order
    {

        private int userId;
        private double total;
        private int amount;
        private string pizzaType;
        private string size;
        private string crust;

        public Pizzas(int userId, double total, int amount, string pizzaType, string size, string crust)
        {
            this.userId = userId;
            this.total = total;
            this.amount = amount;
            this.pizzaType = pizzaType;
            this.size = size;
            this.crust = crust;
        }

        public int UserID
        {
            get { return userId; }
            set { userId = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string PizzaType
        {
            get { return pizzaType; }
            set { pizzaType = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Crust
        {
            get { return crust; }
            set { crust = value; }
        }
    }
    
}
