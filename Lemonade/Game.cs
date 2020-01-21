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
        Recipe recipe;

        public Random random;

        int currentDay;

        //Constructor
        public Game()
        {
            random = new Random();
            player = new Player();
            days = new List<Day>();
            day = new Day();
            store = new Store();
            currentDay = 1;
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
            // Runs Game            
            UserInterface.DisplayStore(store.bulkLemonPrice, player.inventory.lemons.Count,
                                       store.bulkSugarPrice, player.inventory.sugarCubes.Count,
                                       store.bulkIcePrice, player.inventory.iceCubes.Count,
                                       store.bulkCupPrice, player.inventory.cups.Count,
                                       player.wallet.Money, currentDay, days[currentDay - 1].weather.predictedForecast);
            BuyItems(player);
            UserInterface.DisplayRecipe(player.recipe.amountOfLemons, player.inventory.lemons.Count,
                                        player.recipe.amountOfSugarCubes, player.inventory.sugarCubes.Count,
                                        player.recipe.amountOfIceCubes, player.inventory.iceCubes.Count, player.recipe.pricePerCup);
            AddItems();

            Console.WriteLine("There are {0} customers today", days[currentDay - 1].customers.Count); // This is for testing only, To be removed
            Console.ReadLine();
        }
        public void CheckCurrentDay()
        {
            do
            {
                player.inventory.iceCubes.Clear(); // removes all ice each day               
                Console.Clear();
                RunGame();
                try
                {
                    days[currentDay] = new Day();
                }
                catch (Exception)
                {
                    UserInterface.DisplayGameOver();
                    break;
                }
                currentDay++;
            } while (player.wallet.Money != 0 && currentDay <= days.Count);
        }
        public void RunDay()
        {
            // Potentially sell to each customer
            double salesPrice = player.recipe.pricePerCup;
            int cupsSold = 0;
            foreach (Customer customer in day.customers)
            {
                if (customer.maxPrice <= salesPrice && customer.chanceToBuy > 0)
                {
                    player.SellCup();
                    cupsSold++;
                }
            }
            Console.WriteLine("You sold {0} cups of lemonade!", cupsSold); //for testing, move to UI
            Console.WriteLine("You now have {0}", player.wallet.Money); //for testing, move to UI
        }
        public void AddItems()
        {
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
                    player.recipe.CupPrice(player.inventory);
                    AddItems();
                    break;
                case "5":
                    RunDay();
                    break;
                case "6":
                    UserInterface.DisplayStore(store.bulkLemonPrice,
                        player.inventory.lemons.Count, store.bulkSugarPrice,
                        player.inventory.sugarCubes.Count, store.bulkIcePrice,
                        player.inventory.iceCubes.Count, store.bulkCupPrice,
                        player.inventory.cups.Count, player.wallet.Money, currentDay, days[-1].weather.predictedForecast);
                    break;
            }
        }
        public void BuyItems(Player player)
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    store.BuyLemons(player);
                    UserInterface.DisplayStore(store.bulkLemonPrice, player.inventory.lemons.Count, store.bulkSugarPrice, 
                        player.inventory.sugarCubes.Count, store.bulkIcePrice, player.inventory.iceCubes.Count, 
                        store.bulkCupPrice, player.inventory.cups.Count, player.wallet.Money, currentDay, 
                        days[currentDay - 1].weather.predictedForecast);
                    BuyItems(player);
                    break;
                case "2":
                    store.BuySugarCubes(player);
                    UserInterface.DisplayStore(store.bulkLemonPrice, player.inventory.lemons.Count, store.bulkSugarPrice,
                        player.inventory.sugarCubes.Count, store.bulkIcePrice, player.inventory.iceCubes.Count,
                        store.bulkCupPrice, player.inventory.cups.Count, player.wallet.Money, currentDay,
                        days[currentDay - 1].weather.predictedForecast);
                    BuyItems(player);
                    break;
                case "3":
                    store.BuyIceCubes(player);
                    UserInterface.DisplayStore(store.bulkLemonPrice, player.inventory.lemons.Count, store.bulkSugarPrice,
                        player.inventory.sugarCubes.Count, store.bulkIcePrice, player.inventory.iceCubes.Count,
                        store.bulkCupPrice, player.inventory.cups.Count, player.wallet.Money, currentDay,
                        days[currentDay - 1].weather.predictedForecast);
                    BuyItems(player);
                    break;
                case "4":
                    store.BuyCups(player);
                    UserInterface.DisplayStore(store.bulkLemonPrice, player.inventory.lemons.Count, store.bulkSugarPrice,
                        player.inventory.sugarCubes.Count, store.bulkIcePrice, player.inventory.iceCubes.Count,
                        store.bulkCupPrice, player.inventory.cups.Count, player.wallet.Money, currentDay,
                        days[currentDay - 1].weather.predictedForecast);
                    BuyItems(player);
                    break;
                case "5":
                    UserInterface.DisplayRecipe(player.recipe.amountOfLemons, player.inventory.lemons.Count,
                         player.recipe.amountOfSugarCubes, player.inventory.sugarCubes.Count, player.recipe.amountOfIceCubes,
                         player.inventory.iceCubes.Count, player.recipe.pricePerCup);
                    break;
                default:
                    {
                        UserInterface.NotAValidOption();
                        BuyItems(player);
                        break;
                    }
            }
        }
    }
}
