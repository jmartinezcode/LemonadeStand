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
            try
            {
                amountOfLemons = Int32.Parse(Console.ReadLine());
                if (amountOfLemons > inventory.lemons.Count)
                {
                    UserInterface.NotEnoughInventory(inventory.lemons[0].name);
                    AddLemons(inventory);
                }
            }
            catch (FormatException)
            {
                UserInterface.NotAValidOption();
                AddLemons(inventory);
            }
        }
        public void AddSugar(Inventory inventory)
        {
            SugarCube sugarCube = new SugarCube();
            UserInterface.AddItemsToRecipe(sugarCube.name);
            try
            {
                amountOfSugarCubes = Int32.Parse(Console.ReadLine());
                if (amountOfSugarCubes > inventory.sugarCubes.Count)
                {
                    UserInterface.NotEnoughInventory(inventory.sugarCubes[0].name);
                    AddSugar(inventory);
                }
            }
            catch (FormatException)
            {
                UserInterface.NotAValidOption();
                AddSugar(inventory);
            }
        }
        public void AddIce(Inventory inventory)
        {
            IceCube iceCube = new IceCube();
            UserInterface.AddItemsToRecipe(iceCube.name);
            try
            {
                amountOfIceCubes = Int32.Parse(Console.ReadLine());
                if (amountOfIceCubes > inventory.iceCubes.Count)
                {
                    UserInterface.NotEnoughInventory(inventory.iceCubes[0].name);
                }
            }
            catch (FormatException)
            {
                UserInterface.NotAValidOption();
                AddIce(inventory);
            }
        }
        public void CupPrice()
        {
            Console.WriteLine("How much would you like to charge per cup?");
            try
            {
                pricePerCup = Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                UserInterface.NotAValidOption();
                CupPrice();
            }
        }
    }
}
