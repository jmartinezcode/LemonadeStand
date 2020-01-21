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
            Lemon lemon = new Lemon();
            UserInterface.AddItemsToRecipe(lemon.name);
            amountOfLemons = Int32.Parse(Console.ReadLine());
            if (amountOfLemons > inventory.lemons.Count)
            {
                UserInterface.NotEnoughInventory(inventory.lemons[0].name);
            }
            
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup, inventory.cups.Count);
        }
        public void AddSugar(Inventory inventory)
        {
            SugarCube sugarCube = new SugarCube();
            UserInterface.AddItemsToRecipe(sugarCube.name);
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            if (amountOfSugarCubes > inventory.sugarCubes.Count)
            {
                UserInterface.NotEnoughInventory(inventory.sugarCubes[0].name);
            }
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup, inventory.cups.Count);
        }
        public void AddIce(Inventory inventory)
        {
            IceCube iceCube = new IceCube();
            UserInterface.AddItemsToRecipe(iceCube.name);
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
            if (amountOfIceCubes > inventory.iceCubes.Count)
            {
                UserInterface.NotEnoughInventory(inventory.iceCubes[0].name);
            }
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup, inventory.cups.Count);
        }
        public void CupPrice(Inventory inventory)
        {
            Console.WriteLine("How much would you like to charge per cup?");
            pricePerCup = Double.Parse(Console.ReadLine());
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup, inventory.cups.Count);
        }
    }
}
