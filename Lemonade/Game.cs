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
            UserInterface.DisplayStore(store.bulkLemonPrice , player.inventory.lemons.Count, 
                                       store.bulkSugarPrice, player.inventory.sugarCubes.Count, 
                                       store.bulkIcePrice, player.inventory.iceCubes.Count, 
                                       store.bulkCupPrice, player.inventory.cups.Count, 
                                       player.wallet.Money, currentDay, days[currentDay-1].weather.predictedForecast);
            UserInterface.DisplayRecipe(player.recipe.amountOfLemons, player.inventory.lemons.Count,
                                        player.recipe.amountOfSugarCubes, player.inventory.sugarCubes.Count,
                                        player.recipe.amountOfIceCubes, player.inventory.iceCubes.Count);
            Console.WriteLine("There are {0} customers today", days[currentDay -1].customers.Count); // This is for testing only, To be removed
            Console.ReadLine();
        }
        public void CheckCurrentDay()
        {
            do
            {
                player.inventory.iceCubes.Clear();                
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
    }
}
