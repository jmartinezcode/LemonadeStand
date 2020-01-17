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
        }
        //Member Methods (CAN DO)     
        public void SellCup()
        {
        }
        public void RunGame()
        {
            // Runs Game
        }


    }
}
