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
        Lemon lemon;
        SugarCube sugarCube;
        IceCube iceCube;

        //Constructor
        public void AddLemons(Inventory inventory)
        {
            amountOfLemons = Int32.Parse(Console.ReadLine());
            if (amountOfLemons > inventory.lemons.Count)
            {
                UserInterface.NotenoughInventory(lemon.name);
            }
            UserInterface.AdjustingRecipe(amountOfLemons, lemon.name);
        }
        public void AddSugar(Inventory inventory)
        {
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            if (amountOfSugarCubes > inventory.sugarCubes.Count)
            {
                UserInterface.NotenoughInventory(sugarCube.name);
            }
            UserInterface.AdjustingRecipe(amountOfSugarCubes, sugarCube.name);
        }
        public void AddIce(Inventory inventory)
        {
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
            if (amountOfIceCubes > inventory.iceCubes.Count)
            {
                UserInterface.NotenoughInventory(iceCube.name);
            }
            UserInterface.AdjustingRecipe(amountOfIceCubes, iceCube.name);
        }
        public void CupPrice()
        {
            Console.WriteLine("How much would you like to charge per cup?");
            pricePerCup = Int32.Parse(Console.ReadLine());
        }
        
    }
}
