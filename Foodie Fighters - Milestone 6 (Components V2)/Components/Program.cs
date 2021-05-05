using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//We had an extension from Dr. Cai for extenuating circumstances so please accept this.



namespace _322_Foodie_Fighters
{

    public class Waiter
    {
        private List<Order> currentOrders;
        public void addOrder(Order o)
        {

        }
        public void removeOrder(Order o)
        {

        }
        private void processBill()
        {

        }
        public void tellCookingTimerOrder(double d)
        {

        }
    }
    public class Order
    {
        private double priceOfDishes;
        private List<Dish> dishes;
        public double calculatePrice()
        {
            throw new NotImplementedException("Not yet implemented"); //TO-DO
        }
        public void addDish(Dish d)
        {

        }
        public void removeDish(Dish d)
        {

        }
        public void addSubstitution()
        {

        }
    }
    public class Dish
    {
        public string dishName;
        private int itemsInMeal;
        public double mealTimeToPrepare;
        private double mealPrice;

        public void substituteItem()
        {

        }
    }
    public class Item 
    {
        public string itemName;
        private double itemPrice;
        private int itemQuantity;
        void updateQuantity(int n)
        {

        }
    }



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
