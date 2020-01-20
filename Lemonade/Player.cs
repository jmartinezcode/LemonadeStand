using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Player
    {
        //Member Variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        //Constructor
        public Player()
        {
            name = "Player 1";
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
            pitcher = new Pitcher();            
        }

        //Member Methods (CAN DO)
        public void FillPitcher()
        {
            while(pitcher.cupsLeftInPitcher == 0)
            {
                if(inventory.lemons.Count >= recipe.amountOfLemons && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && inventory.iceCubes.Count >= recipe.amountOfIceCubes)
                {
                    for (int i = 0; i < recipe.amountOfLemons; i++)
                    {
                        inventory.lemons.Remove(inventory.lemons[0]);
                    }
                    for (int i = 0; i < recipe.amountOfSugarCubes; i++)
                    {
                        inventory.sugarCubes.Remove(inventory.sugarCubes[0]);
                    }
                    for (int i = 0; i < recipe.amountOfIceCubes; i++)
                    {
                        inventory.iceCubes.Remove(inventory.iceCubes[0]);
                    }
                    pitcher.cupsLeftInPitcher = 12;
                    Console.WriteLine("The pitcher has been refilled");
                }
                else
                {
                    Console.WriteLine("We are sold out");
                }
            }
        }
        public void SellCup()
        {
                pitcher.cupsLeftInPitcher--;
                inventory.cups.Remove(inventory.cups[0]);
                wallet.Money += recipe.pricePerCup;
        }
    }
}
