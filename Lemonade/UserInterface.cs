﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public static class UserInterface
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Hello! Welcome to the"); //Thanks ASCII Art Generator https://www.ascii-art-generator.org/
            Console.WriteLine("    __    ________  _______  _   _____    ____  ______");
            Console.WriteLine("   / /   / ____/  |/  / __ \\/ | / /   |  / __ \\/ ____/");
            Console.WriteLine("  / /   / __/ / /|_/ / / / /  |/ / /| | / / / / __/    ");
            Console.WriteLine(" / /___/ /___/ /  / / /_/ / /|  / ___ |/ /_/ / /___   ");
            Console.WriteLine("/_____/_____/_/  /_/\\____/_/ |_/_/  |_/_____/_____/   ");
            Console.WriteLine("   ______________    _   ______     _________    __  _________");
            Console.WriteLine("  / ___/_  __/   |  / | / / __ \\   / ____/   |  /  |/  / ____/");
            Console.WriteLine("  \\__ \\ / / / /| | /  |/ / / / /  / / __/ /| | / /|_/ / __/   ");
            Console.WriteLine(" ___/ // / / ___ |/ /|  / /_/ /  / /_/ / ___ |/ /  / / /___   ");
            Console.WriteLine("/____//_/ /_/  |_/_/ |_/_____/   \\____/_/  |_/_/  /_/_____/   ");
            Console.ReadLine();
            Console.Clear();
        }
        public static void DisplayGameOver()
        {
            Console.WriteLine("   _________    __  _________");  //Thanks ASCII Art Generator https://www.ascii-art-generator.org/
            Console.WriteLine("  / ____/   |  /  |/  / ____/");
            Console.WriteLine(" / / __/ /| | / /|_/ / __/   ");
            Console.WriteLine("/ /_/ / ___ |/ /  / / /___   ");
            Console.WriteLine("\\____/_/  |_/_/  /_/_____/   ");
            Console.WriteLine("   ____ _    ____________ ");
            Console.WriteLine("  / __ \\ |  / / ____/ __ \\");
            Console.WriteLine(" / / / / | / / __/ / /_/ /");
            Console.WriteLine("/ /_/ /| |/ / /___/ _, _/ ");
            Console.WriteLine("\\____/ |___/_____/_/ |_|  ");
            Console.ReadLine();
            Console.Clear();
        }
        public static string SelectGameLength()
        {
            Console.WriteLine("Select how many days to play:\n=============================\n1.   7 Days\n2.  14 Days\n3.  30 Days");
            string gameLength;
            do
            {
                Console.WriteLine("Please enter 1, 2 or 3");
                gameLength = Console.ReadLine();
            } while (gameLength != "1" && gameLength != "2" && gameLength != "3");
            return gameLength;
        }
        public static void DisplayGameLength(string numberDays)
        {
            Console.Clear();
            Console.WriteLine("You've chosen to play for {0} days!\nPress enter to continue.", numberDays);
            Console.Read();
        }
        public static void DisplayGameStatus()
        {
            // Displays Game's Status 
            Console.WriteLine("You have...");
        }

        public static void DisplayStore(double lemonPrice, int lemonCount, 
                                        double sugarPrice, int sugarCount, 
                                        double icePrice, int iceCount, 
                                        double cupPrice, int cupCount, 
                                        double moneyCount, int dayCount, string forecast)
        {
            Console.WriteLine("Welcome to the Store Day {0}\n=================================================\n", dayCount);
            Console.WriteLine("You currently have: ${0}", moneyCount);
            DisplayForecast(forecast);
            Console.WriteLine("1. Buy 5 Lemons       ${0}     Lemon Inventory: {1}", lemonPrice, lemonCount);
            Console.WriteLine("2. Buy 5 Sugar Cubes  ${0}     Sugar Inventory: {1}", sugarPrice, sugarCount);
            Console.WriteLine("3. Buy 5 Ice Cubes    ${0}     Ice   Inventory: {1}", icePrice, iceCount);
            Console.WriteLine("4. Buy 5 Cups         ${0}     Cup   Inventory: {1}", cupPrice, cupCount);
            Console.WriteLine("5. Exit Store");
        }
        public static void DisplayRecipe(int lemonRecipe, int lemonCount,
                                         int sugarRecipe, int sugarCount,
                                         int iceRecipe, int iceCount,
                                         double cupPrice)
        {
            Console.WriteLine("Your Award Winning Recipe \n=================================================\n");
            Console.WriteLine("1. Lemons per Pitcher:       {0}   Lemon Inventory: {1}", lemonRecipe, lemonCount);
            Console.WriteLine("2. Sugar Cubes per Pitcher:  {0}   Sugar Inventory: {1}", sugarRecipe, sugarCount);
            Console.WriteLine("3. Ice Cubes per Pitcher:    {0}   Ice   Inventory: {1}", iceRecipe, iceCount);
            Console.WriteLine("4. Price Per Cup:            {0}", cupPrice);
            Console.WriteLine("5. Begin Round!");
            Console.WriteLine("6. Go to the Store");
            Console.WriteLine("Enter the number of the ingredient you would like to change (1-3)");
        }
        public static void DisplayForecast(string forecast)
        {
            Console.WriteLine("Today's Predicted Weather: {0}\n", forecast);
        }
        public static void PlayAgainPrompt()
        {
            string playAgain;
            do
            {
                Console.WriteLine("Would you like to play again? (y or n)");
                playAgain = Console.ReadLine();
            } while (playAgain != "y" && playAgain != "n");
            if (playAgain == "y")
            {
                Console.WriteLine("Great! Let's play again!");
                // Reset game here
                // CheckCurrentDay();
                // GameOver();
            }
            else
            {
                Console.WriteLine("See you next time!");
            }
        }
        public static void AdjustingRecipe(int itemCount, string itemName)
        {
            Console.WriteLine($"You added {itemCount} {itemName}s to the recipe.");
        }
        public static void NotEnoughMoney(string itemName)
        {
            Console.WriteLine($"You do not have enough funds to purchase {itemName}s");
        }
        public static void NotEnoughInventory(string itemName)
        {
            Console.WriteLine($"You do not have enough {itemName}s in your inventory to add it to the recipe");
        } 
        public static void BuyItem(int itemCount, string itemName)
        {
            Console.WriteLine("You bought {0} {1}s!", itemCount, itemName);
        }
        public static void NotAValidOption()
        {
            Console.WriteLine("You did not choose a valid option. Please choose again.");
        }
        public static void AddItemsToRecipe(string itemName)
        {
            Console.WriteLine($"How many {itemName}s would you like to add to the recipe?");
        }
    }
}
