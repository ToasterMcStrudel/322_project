using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _322_Foodie_Fighters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TrendsStatsManagement.Database.menuPrices["Torikatsu"] = 15.95;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*TrendsStatsManagement.Database.dishesOrdered = new Dictionary<string, int>();


            TrendsStatsManagement.Database.dishesOrdered["Torikatsu"] = 6;
            TrendsStatsManagement.Database.dishesOrdered["Bulgogi"] = 105;
            TrendsStatsManagement.Database.dishesOrdered["Bi Bim Bap"] = 2;
            TrendsStatsManagement.Database.dishesOrdered["Vegetable Tempura"] = 3;
            TrendsStatsManagement.Database.dishesOrdered["Meat"] = 20;
            TrendsStatsManagement.Database.dishesOrdered["Fish"] = 1;
            TrendsStatsManagement.Database.dishesOrdered["Vegg"] = 13;
            TrendsStatsManagement.Database.dishesOrdered["Bread"] = 17;
            TrendsStatsManagement.Database.dishesOrdered["Carb"] = 43;*/

            TrendsStatsManagement.TrendCalculator.rankMostPopularItems();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrendsStatsManagement.Database.recordDishOrdered("Torikatsu", 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrendsStatsManagement.Database.recordDishOrdered("Bulgogi", 1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string dish = textBox1.Text;
            TrendsStatsManagement.Database.recordDishOrdered(dish, 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TrendsStatsManagement.TrendCalculator.calculateApproximateRevenue();
        }
    }









}
