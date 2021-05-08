  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _322_Foodie_Fighters
{
    static public class TrendsStatsManagement
    {
        static public class Inventory
        {
            static public Dictionary<Item, int> itemList;
        }
        static public class Database
        {
            static public Dictionary<Item, double> itemPrices = new Dictionary<Item, double>();
            static public Dictionary<string, Dish> menu = new Dictionary<string, Dish>();
            static public Dictionary<string, double> menuPrices = new Dictionary<string, double>();
            static public Dictionary<string, int> dishesOrdered = new Dictionary<string, int>();
            static public Dictionary<string, double> prepTimeRecords = new Dictionary<string, double>();

            static Database()
            {
                //Dictionary<string, int> dishesOrdered = new Dictionary<string, int>();
            }


            static public void recordDishOrdered(string dish, int quantity)
            {
                int value = 0;
                bool existsAlready = dishesOrdered.TryGetValue(dish, out value);
                if (existsAlready) {
                    dishesOrdered[dish] += quantity;
                }
                else
                {
                    dishesOrdered[dish] = quantity;
                }
            }

        }
        static public class TrendCalculator
        {
            static public Dictionary<string, int> rankMostPopularItems()
            {
                int currentValue = 0, max = -1;
                string currentKey = "";
                Dictionary<string, int> result = new Dictionary<string, int> ();
                Dictionary<string, int> copy = new Dictionary<string, int>(Database.dishesOrdered);

                //A simple sort on dishesOrdered
                int dishesNum = copy.Count;
                for (int i = 0; i < dishesNum; i++)
                {
                    //Console.WriteLine("On {0}", i);
                    foreach (KeyValuePair<string, int> entry in copy)
                    {
                        //Console.WriteLine("\tNow on " + entry.Key);
                        if (entry.Value > max) {
                            currentValue = entry.Value;
                            currentKey = entry.Key;
                            max = entry.Value;
                        }
                    }
                    copy.Remove(currentKey);
                    result[currentKey] = currentValue;
                    max = -1;
                }


                Console.WriteLine("\nYour most popular items are as follows:");
                foreach (KeyValuePair<string, int> entry in result)
                {
                    Console.WriteLine(entry.Key + " : " + entry.Value);
                }

                return result;

            }
            static public void rankDishPrepTimes()
            {
                //Should be a simple sort on dishesOrdered
            }
            static public double findAvgPrepTime(Dictionary<string, int> dishesOrdered, Dictionary<string, double> prepTimeRecords, string dishName)
            {
                //Should be a simple search in prepTimeRecords and divide by the value from dishesOrdered
                int num = Database.dishesOrdered[dishName];
                double totalPrepTime = Database.prepTimeRecords[dishName];
                return totalPrepTime / num;
            }

            //Consults dishesOrdered and menuPrices to find the total money that should have been gained from selling dishes.
            static public double calculateApproximateRevenue()
            {
                double value = 0f, totalRev = 0f;
                List<string> dishesWithoutPrices = new List<String>();

                foreach (KeyValuePair<string, int> entry in Database.dishesOrdered)
                {
                    bool existsAlready = Database.menuPrices.TryGetValue(entry.Key, out value);
                    if (existsAlready)
                    {
                        totalRev += (value * Database.dishesOrdered[entry.Key]);
                    }
                    else
                    {
                        dishesWithoutPrices.Add(entry.Key);
                    }
                }

                Console.WriteLine("\n\nYou have made approximately $" + Math.Round(totalRev, 2) + " from orders.\n");

                foreach (string dish in dishesWithoutPrices)
                {
                    Console.WriteLine("Error: " + dish + " has no price set yet.\n");
                }

                return totalRev;
            }


        }


    }
}
