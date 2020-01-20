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
        
        public Random random;

        int currentDay;
        
        //Constructor
        public Game()
        {
            random = new Random();
            player = new Player();
            days = new List<Day>();
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

        public void SellCup()
        {
        }
        public void RunGame()
        {
            // Runs Game            
            Console.WriteLine(days.Count);
            Console.ReadLine();
            UserInterface.DisplayGameOver();
        }

        public void CheckCurrentDay()
        {
            do
            {
                RunGame();
            } while (player.wallet.Money != 0 && currentDay < days.Count);
        }



    }
}
