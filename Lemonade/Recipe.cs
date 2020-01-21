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
        Player player;

        //Constructor
        public void AddLemons(Inventory inventory)
        {
            amountOfLemons = Int32.Parse(Console.ReadLine());
            if (amountOfLemons > inventory.lemons.Count)
            {
                UserInterface.NotEnoughInventory(lemon.name);
            }
        }
        public void AddSugar(Inventory inventory)
        {
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            if (amountOfSugarCubes > inventory.sugarCubes.Count)
            {
                UserInterface.NotEnoughInventory(sugarCube.name);
            }
        }
        public void AddIce(Inventory inventory)
        {
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
            if (amountOfIceCubes > inventory.iceCubes.Count)
            {
                UserInterface.NotEnoughInventory(iceCube.name);
            }
        }
        public void CupPrice()
        {
            Console.WriteLine("How much would you like to charge per cup?");
            pricePerCup = Int32.Parse(Console.ReadLine());
        }
        public void AddItems(Inventory inventory)
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    UserInterface.AddItemsToRecipe(lemon.name);
                    amountOfLemons = Int32.Parse(Console.ReadLine());
                    if (amountOfLemons > inventory.lemons.Count)
                    {
                        UserInterface.NotEnoughInventory(lemon.name);
                    }
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count, 
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes, 
                        inventory.iceCubes.Count,pricePerCup);
                    break;
                case "2":
                    UserInterface.AddItemsToRecipe(sugarCube.name);
                    amountOfSugarCubes = Int32.Parse(Console.ReadLine());
                    if (amountOfSugarCubes > inventory.sugarCubes.Count)
                    {
                        UserInterface.NotEnoughInventory(sugarCube.name);
                    }
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                         amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                         inventory.iceCubes.Count, pricePerCup);
                    break;
                case "3":
                    UserInterface.AddItemsToRecipe(iceCube.name);
                    amountOfIceCubes = Int32.Parse(Console.ReadLine());
                    if (amountOfIceCubes > inventory.iceCubes.Count)
                    {
                        UserInterface.NotEnoughInventory(iceCube.name);
                    }
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                         amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                         inventory.iceCubes.Count, pricePerCup);
                    break;
                case "4":
                    Console.WriteLine("How much would you like to charge per cup?");
                    pricePerCup = Double.Parse(Console.ReadLine());
                    UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                         amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                         inventory.iceCubes.Count, pricePerCup);
                    break; // added to fix testing, remove if necessary
                case "5":
                    break;
                case "6":
                    Store store = new Store();
                    //UserInterface.DisplayStore(store.bulkLemonPrice, inventory.lemons.Count, store.bulkSugarPrice, inventory.sugarCubes.Count, store.bulkIcePrice, inventory.iceCubes.Count, store.bulkCupPrice, inventory.cups.Count, player.wallet.Money,);
                    break;
            }
        }
    }
}
