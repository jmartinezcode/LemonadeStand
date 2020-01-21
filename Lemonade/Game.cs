using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Game
    {
        //Member Variables (HAS A)
        Player player;
        List<Day> days;
        Day day;
        Store store;

        public Random random;

        int currentDay;
        double maxPrice;

        //Constructor
        public Game()
        {
            random = new Random();
            player = new Player();
            days = new List<Day>();
            day = new Day();
            store = new Store();
            currentDay = 1;
            maxPrice = 0.35;
            UserInterface.DisplayWelcomeMessage();
            string input = UserInterface.SelectGameLength();
            SetGameLength(input);
            CheckCurrentDay();
        }
        //Member Methods (CAN DO)            

        public void SetGameLength(string gameLength)
        {
            if (gameLength == "1") // 7 day game
            {
                UserInterface.DisplayGameLength("7");
                for (int i = 0; i < 7; i++)
                {
                    days.Add(day);
                }
            }
            else if (gameLength == "2") // 14 day game
            {
                UserInterface.DisplayGameLength("14");
                for (int i = 0; i < 14; i++)
                {
                    days.Add(day);
                }
            }
            else // 30 day game
            {
                UserInterface.DisplayGameLength("30");
                for (int i = 0; i < 30; i++)
                {
                    days.Add(day);
                }
            }
        }
        public void RunGame()
        {
            BuyItems(player);
            AddItems();
        }
        public void CheckCurrentDay()
        {
            do
            {
                player.inventory.iceCubes.Clear(); // removes all ice each day               
                Console.Clear();                
                try
                {
                    RunGame();
                    days[currentDay] = new Day();                    
                }
                catch (Exception)
                {
                    UserInterface.DisplayGameOver();
                    break;
                }                
            } while (player.wallet.Money != 0 && currentDay <= days.Count);
        }
        public void RunDay()
        {
            // Potentially sell to each customer
            double salesPrice = player.recipe.pricePerCup;
            int cupsSold = 0;
            double chanceThreshold = 1.5;
            player.FillPitcher();
            CalcCustomerChanceToBuy();
            foreach (Customer customer in day.customers)
            {
                if (salesPrice <= customer.maxPrice && customer.chanceToBuy > chanceThreshold && player.inventory.cups.Count > 0)
                {
                    player.SellCup();
                    cupsSold++;
                }
            }
            UserInterface.DisplayEndOfDayReport(currentDay, cupsSold, days[currentDay - 1].customers.Count,
                                                player.wallet.Money, day.weather.predictedForecast, day.weather.temperature, day.weather.condition);
            currentDay++;
            CheckCurrentDay();
        }
        public void AddItems()
        {
            UserInterface.DisplayRecipe(player.recipe.amountOfLemons, player.inventory.lemons.Count,
                                        player.recipe.amountOfSugarCubes, player.inventory.sugarCubes.Count,
                                        player.recipe.amountOfIceCubes, player.inventory.iceCubes.Count,
                                        player.recipe.pricePerCup, player.inventory.cups.Count);
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    player.recipe.AddLemons(player.inventory);
                    AddItems();
                    break;
                case "2":
                    player.recipe.AddSugar(player.inventory);
                    AddItems();
                    break;
                case "3":
                    player.recipe.AddIce(player.inventory);
                    AddItems();
                    break;
                case "4":
                    player.recipe.CupPrice();
                    AddItems();
                    break;
                case "5":
                    RunDay();
                    break;
                case "6":
                    BuyItems(player);
                    break;
            }
        }

        public void BuyItems(Player player)
        {
            UserInterface.DisplayStore(store.bulkLemonPrice, player.inventory.lemons.Count, store.bulkSugarPrice,
                        player.inventory.sugarCubes.Count, store.bulkIcePrice, player.inventory.iceCubes.Count,
                        store.bulkCupPrice, player.inventory.cups.Count, player.wallet.Money, currentDay,
                        days[currentDay - 1].weather.predictedForecast, store.bulkQty);
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    store.BuyLemons(player);                    
                    BuyItems(player);
                    break;
                case "2":
                    store.BuySugarCubes(player);
                    BuyItems(player);
                    break;
                case "3":
                    store.BuyIceCubes(player);
                    BuyItems(player);
                    break;
                case "4":
                    store.BuyCups(player);
                    BuyItems(player);
                    break;
                case "5":
                    AddItems();
                    break;
                default:
                    {
                        UserInterface.NotAValidOption();
                        BuyItems(player);                                                                    
                        break;
                    }
            }
        }
        public void CalcCustomerChanceToBuy()
        {
            double chanceToBuy = PriceFactor() + HeatFactor();
            foreach (Customer customer in day.customers)
            {
                customer.maxPrice = random.Next(36) / 100.0; // price customer willing to pay between 0 and 0.35 
                customer.chanceToBuy = random.NextDouble();  // 
                customer.chanceToBuy += chanceToBuy;
            }
        }
        public double PriceFactor()
        {
            return (maxPrice - player.recipe.pricePerCup) / maxPrice; // less demand for each cent increase in price
        }
        public double HeatFactor()
        {
            return 1 - (100 - days[currentDay - 1].weather.temperature) * 2 / 100.0; // 2% more demand for every degree above 50 0-1 should be .5 on average
        }
    }
}
