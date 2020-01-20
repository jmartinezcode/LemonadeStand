using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Recipe
    {
        //Member Variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        //Constructor
        public void AddLemons(Inventory inventory)
        {
            Console.WriteLine("How many lemons do you want to add?");
            amountOfLemons = Int32.Parse(Console.ReadLine());
            if (amountOfLemons > inventory.lemons.Count)
            {
                Console.WriteLine("You do not have enough lemons");
            }
        }
        public void AddSugar(Inventory inventory)
        {
            Console.WriteLine("How many sugar cubes do you want to add?");
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            if (amountOfSugarCubes > inventory.sugarCubes.Count)
            {
                Console.WriteLine("You do not have enough sugar cubes.");
            }
        }
        public void AddIce(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes do you want to add?");
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
            if (amountOfIceCubes > inventory.iceCubes.Count)
            {
                Console.WriteLine("You do not have enough ice cubes");
            }
        }
        public void CupPrice()
        {
            Console.WriteLine("How much would you like to charge per cup?");
            pricePerCup = Int32.Parse(Console.ReadLine());
        }
    }
}
