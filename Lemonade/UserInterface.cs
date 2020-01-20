using System;
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
            Console.WriteLine("You've chosen to play for {0} days!", numberDays);
        }
        public static void DisplayGameStatus()
        {
            // Displays Game's Status 
            Console.WriteLine("You have...");
        }

        public static void DisplayStore(int lemonCount, int sugarCount, int iceCount, int cupCount, double moneyCount)
        {
            Console.WriteLine("Welcome to the Store\n=================================================\n");
            Console.WriteLine("You currently have: ${0}\n", moneyCount);
            Console.WriteLine("1. Buy 5 Lemons            Lemon Inventory: {0}", lemonCount);
            Console.WriteLine("2. Buy 5 Sugar Cubes       Sugar Inventory: {0}", sugarCount);
            Console.WriteLine("3. Buy 5 Ice Cubes         Ice   Inventory: {0}", iceCount);
            Console.WriteLine("4. Buy 5 Cups              Cup   Inventory: {0}", cupCount);
            Console.WriteLine("5. Exit Store");
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
    }
}
