﻿using System;
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
            WelcomeMessage();
            DisplayStatus();
        }
        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            // Welcome message to the player
            Console.WriteLine("Welcome to the Lemonade Stand Game!");
        }
        public void DisplayStatus()
        {
            // Displays Current Status of the game: Predicted Weather, Current Money, etc.
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
