using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiShop
{
    public class CashRegister
    {
        public double TotalCost { get; set; }

        private Dictionary<string, double> costs;

        public CashRegister()
        {
            TotalCost = 0;
            costs = new Dictionary<string, double>();
            setupDefaultMenu();
        }

        private void setupDefaultMenu()
        {
            costs.Add("Spaghetti", 3.0);
            costs.Add("Mostaccioli", 3.5);
            costs.Add("Angel Hair", 2.5);

            costs.Add("House Red", 1.0);
            costs.Add("Squid Ink", 5);
            costs.Add("Meat", 2);
            costs.Add("Alfredo", 1.5);

            costs.Add("Garlic", .5);
            costs.Add("Chicken", 1);
            costs.Add("MeatBall", 2);
            costs.Add("Shrimp", 3);
        }

        public void addItem(string other)
        {
            if ( costs.ContainsKey( other))
            {
                TotalCost += costs[other];
            }
        }

        public double GetPriceOf(string item)
        {
            return costs.ContainsKey(item) ? costs[item] : 0.0;
        }

        public double GetTotalPrice()
        {
            return TotalCost;
        }
    }
}
