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
                UserInterface.NotenoughInventory(inventory.iceCubes[0].name);
            }
            UserInterface.AdjustingRecipe(amountOfIceCubes, inventory.iceCubes[0].name);
        }
        public void CupPrice()
        {
            Console.WriteLine("How much would you like to charge per cup?");
            pricePerCup = Int32.Parse(Console.ReadLine());
        }
<<<<<<< HEAD
        public void AddItems(Inventory inventory)
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    UserInterface.AddItemsToRecipe(inventory.lemons[0].name);
                    amountOfLemons = Int32.Parse(Console.ReadLine());
                    if (amountOfLemons > inventory.lemons.Count)
                    {
                        UserInterface.NotenoughInventory(lemon.name);
                    }
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count, 
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes, 
                        inventory.iceCubes.Count,pricePerCup);
                    break;
                case "2":
                    UserInterface.AddItemsToRecipe(inventory.sugarCubes[0].name);
                    amountOfSugarCubes = Int32.Parse(Console.ReadLine());
                    if (amountOfSugarCubes > inventory.sugarCubes.Count)
                    {
                        UserInterface.NotenoughInventory(sugarCube.name);
                    }
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                         amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                         inventory.iceCubes.Count, pricePerCup);
                    break;
                case "3":
                    UserInterface.AddItemsToRecipe(inventory.iceCubes[0].name);
                    amountOfIceCubes = Int32.Parse(Console.ReadLine());
                    if (amountOfIceCubes > inventory.iceCubes.Count)
                    {
                        UserInterface.NotenoughInventory(inventory.iceCubes[0].name);
                    }
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                         amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                         inventory.iceCubes.Count, pricePerCup);
                    break;
                case "4":
                    Console.WriteLine("How much would you like to charge per cup?");
                    pricePerCup = Int32.Parse(Console.ReadLine());
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                         amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                         inventory.iceCubes.Count, pricePerCup);
                    break;
            }
        }
=======
        
>>>>>>> 05fe2360b6b42a51921bfaff0c413a96a5a4a474
    }
}
