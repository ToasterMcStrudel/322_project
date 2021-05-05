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
            static public Dictionary<Item, double> itemPrices;
            static public Dictionary<Dish, double> menuPrices;
            static public Dictionary<Dish, int> dishesOrdered;
            static public Dictionary<Dish, double> prepTimeRecords;
            static public void recordDishOrdered(Dish d, int quantity)
            {

            }
        }
        static public class TrendCalculator
        {
            static public void rankMostPopularItems()
            {
                //Should be a simple sort on dishesOrdered
            }
            static public void rankDishPrepTimes()
            {
                //Should be a simple sort on dishesOrdered
            }
            static public double findAvgPrepTime(Dish d)
            {
                //Should be a simple search in prepTimeRecords and divide by the value from dishesOrdered
                int num = Database.dishesOrdered[d];
                double totalPrepTime = Database.prepTimeRecords[d];
                return totalPrepTime / num;
            }
        }


    }
}
