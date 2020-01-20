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
        int currentDay;
        public Random random;

        //Constructor
        public Game()
        {
            random = new Random();
            player = new Player();
            days = new List<Day>();
            UserInterface.DisplayWelcomeMessage();
            SelectGameLength();
            UserInterface.DisplayGameOver();
        }
        //Member Methods (CAN DO)    
        public void SelectGameLength()
        {
            Console.WriteLine("Select how many days to play:\n=============================\n1.   7 Days\n2.  14 Days\n3.  30 Days");
        }

        public void SellCup()
        {
        }
        public void RunGame()
        {
            // Runs Game
        }



    }
}
