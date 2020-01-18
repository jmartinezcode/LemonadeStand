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
        public Customer()
        {
            
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
            if(weather.temperature >= 90)
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
            else if (weather.temperature >=70)
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

        //public string RandomCustomerName()
        //{
        //    //choose random name from list
        //    List<string> nameslist = new List<string>() { "eva", "lorine", "carolee", "juan", "parthenia", "cory",
        //                                                  "dung", "larisa", "cyndi", "rubye", "aja", "jerrold",
        //                                                  "johnette", "april", "criselda", "tressa", "theressa",
        //                                                  "isidro", "renata", "danyell", "perry", "fe", "jeremy",
        //                                                  "dionne", "dessie",  "toby", "christiana", "stanton", "leona",
        //                                                  "barabara", "buddy", "lynn", "freddy", "numbers", "mae",
        //                                                  "isela", "macy", "alessandra", "sondra", "ashlyn", "jacinda",
        //                                                  "erick", "maryanna", "thora", "junita", "lizeth", "alena",
        //                                                  "mandy", "lisbeth", "wendi" };
        //    return name = nameslist[random.Next(nameslist.Count)];
        //}
        public void CalculatePriceFactor(Recipe recipe, Player player)
        {
            if(recipe.pricePerCup >= 1)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 9)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .9 && recipe.pricePerCup < 1)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 8)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .8 && recipe.pricePerCup < .9)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 7)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .7 && recipe.pricePerCup < .8)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 6)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .6 && recipe.pricePerCup < .7)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 5)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .5 && recipe.pricePerCup < .6)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 4)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .4 && recipe.pricePerCup < .5)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 3)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .3 && recipe.pricePerCup < .4)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 2)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup >= .2 && recipe.pricePerCup < .3)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 1)
                {
                    player.SellCup();
                }
            }
            if (recipe.pricePerCup > .2)
            {
                int randombuy;
                randombuy = random.Next(0, 10);
                if (randombuy >= 0)
                {
                    player.SellCup();
                }
            }
        }
    }
}
