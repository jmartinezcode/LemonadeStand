using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Customer
    {
        public string name;
        Random random;
        public double maxPrice;
        public double chanceToBuy;
        public Customer(string name)
        {
            random = new Random();
            this.name = name;
            maxPrice = random.Next(15, 36) / 100.0; //Max Price customer is willing to pay            
            chanceToBuy = random.Next(2);
        }

        public double PriceFactor(Recipe recipe)
        {
            return (100 - recipe.pricePerCup) / 100.0; // 1% less demand for each cent increase in price
        }
        public double HeatFactor(Weather weather)
        {
            return 1 - (100 - weather.temperature) * 2 / 100.0; // 2% more demand for every degree above 50
        }
    }
}
