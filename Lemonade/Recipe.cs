﻿using System;
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
            UserInterface.AddItemsToRecipe(lemon.name);
            amountOfLemons = Int32.Parse(Console.ReadLine());
            if (amountOfLemons > inventory.lemons.Count)
            {
                UserInterface.NotEnoughInventory(lemon.name);
            }
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup);
        }
        public void AddSugar(Inventory inventory)
        {
            UserInterface.AddItemsToRecipe(sugarCube.name);
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            if (amountOfSugarCubes > inventory.sugarCubes.Count)
            {
                UserInterface.NotEnoughInventory(sugarCube.name);
            }
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup);
        }
        public void AddIce(Inventory inventory)
        {
            UserInterface.AddItemsToRecipe(iceCube.name);
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
            if (amountOfIceCubes > inventory.iceCubes.Count)
            {
                UserInterface.NotEnoughInventory(iceCube.name);
            }
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup);
        }
        public void CupPrice(Inventory inventory)
        {
            Console.WriteLine("How much would you like to charge per cup?");
            pricePerCup = Int32.Parse(Console.ReadLine());
            UserInterface.DisplayRecipe(amountOfLemons, inventory.lemons.Count,
                        amountOfSugarCubes, inventory.sugarCubes.Count, amountOfIceCubes,
                        inventory.iceCubes.Count, pricePerCup);
        }

    }
}
