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
        public void AddLemons()
        {
            Console.WriteLine("How many lemons do you want to add?");
            amountOfLemons = Int32.Parse(Console.ReadLine());
            if (amountOfLemons > lemons.Count)
            {

            }
        }
        public void AddSugar()
        {
            Console.WriteLine("How many sugar cubes do you want to add?");
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            if (amountOfSugarCubes > sugarCubes.Count)
            {

            }
        }
        public void AddIce()
        {
            Console.WriteLine("How many ice cubes do you want to add?");
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
            if (amountOfIceCubes > iceCubes.Count)
            {

            }
        }
        public void CupPrice()
        {
            Console.WriteLine("How much would you like to charge per cup?");
            pricePerCup = Int32.Parse(Console.ReadLine());
        }
    }
}
