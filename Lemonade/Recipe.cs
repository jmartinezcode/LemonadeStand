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
                amountOfLemons = Math.Abs(Int32.Parse(Console.ReadLine()));
                if (amountOfLemons > inventory.lemons.Count)
                {
                    UserInterface.NotEnoughInventory(lemon.name);
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
                amountOfSugarCubes = Math.Abs(Int32.Parse(Console.ReadLine()));
                if (amountOfSugarCubes > inventory.sugarCubes.Count)
                {
                    UserInterface.NotEnoughInventory(sugarCube.name);
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
                amountOfIceCubes = Math.Abs(Int32.Parse(Console.ReadLine()));
                if (amountOfIceCubes > inventory.iceCubes.Count)
                {
                    UserInterface.NotEnoughInventory(iceCube.name);
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
                pricePerCup = Math.Abs(Double.Parse(Console.ReadLine()));
                if (pricePerCup <= 0)
                {
                    UserInterface.NotAValidOption();
                }                
            }
            catch (FormatException)
            {
                UserInterface.NotAValidOption();
                CupPrice();
            }
        }
    }
}
