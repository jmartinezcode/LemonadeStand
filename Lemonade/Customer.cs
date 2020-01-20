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
            maxPrice = random.Next(36) / 100.0; //Max Price customer is willing to pay
            chanceToBuy = random.Next(2);
        }
        // TO DO
        // Implement a price factor, weather and heat factor
        // The price of product as well as weather/temperature should affect demand, 
        // so that if the price is too high, sales will decrease, or if the price is too low, 
        // sales will increase, etc.
        
        public void ProbabilityToPurchase(Weather weather, Player player)
        {
            int randomBuy;
            randomBuy = random.Next(10);
            if (weather.temperature >= 90)
            {
                if (randomBuy > 1) // 80% 
                {
                    player.SellCup();
                }
            }
            else if (weather.temperature >= 80)
            {
                if (randomBuy > 3) // 60%
                {
                    player.SellCup();
                }
            }
            else if (weather.temperature >= 70)
            {
                if (randomBuy > 5) // 40%
                {
                    player.SellCup();
                }
            }
            else
            {
                if (randomBuy > 7) // 20%
                {
                    player.SellCup();
                }
            }
        }

        // Need to implement price and weather factor
        public void PriceFactor(Recipe recipe)
        {
            double priceFactor = (100 - recipe.pricePerCup) / 100.0; // 1% less demand for each cent increase in price
        }
        public void HeatFactor(Weather weather)
        {
            double heatFactor = 1 - (100 - weather.temperature) * 2 / 100.0; // 2% more demand for every degree above 50
        }
        public void CalculatePriceFactor(Recipe recipe, Player player)
        {
            int randomBuy;
            randomBuy = random.Next(10);
            if (recipe.pricePerCup >= 1)
            {
                if (randomBuy >= 9) // 10%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .9)
            {
                if (randomBuy >= 8) // 20%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .8)
            {
                if (randomBuy >= 7) // 30%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .7)
            {
                if (randomBuy >= 6) // 40%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .6)
            {
                if (randomBuy >= 5) // 50%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .5)
            {
                if (randomBuy >= 4) // 60%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .4)
            {
                if (randomBuy >= 3) // 70%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .3)
            {
                if (randomBuy >= 2) // 80%
                {
                    player.SellCup();
                }
            }
            else if (recipe.pricePerCup >= .2)
            {
                if (randomBuy >= 1) // 90%
                {
                    player.SellCup();
                }
            }
            else
            {
                player.SellCup();
            }
        }
    }
}
