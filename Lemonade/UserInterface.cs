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
        
        public static void DisplayGameStatus()
        {
            // Displays Game's Status 
            Console.WriteLine("You have...");
        }

        public static void DisplayStore()
        {
            Console.WriteLine("Welcome to the Store\n===================\n");
            Console.WriteLine("1. Buy 5 Lemons     Lemon Inventory: {0}");
        }
    }
}
