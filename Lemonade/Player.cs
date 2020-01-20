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
                if(inventory.lemons.Count >= recipe.amountOfLemons && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && inventory.iceCubes.Count >= recipe.amountOfIceCubes && inventory.cups.Count > 0)
                {
                    for (int i = 0; i < recipe.amountOfLemons; i++)
                    {
                        inventory.lemons.Remove(new Lemon());
                    }
                    for (int i = 0; i < recipe.amountOfSugarCubes; i++)
                    {
                        inventory.sugarCubes.Remove(new SugarCube());
                    }
                    for (int i = 0; i < recipe.amountOfIceCubes; i++)
                    {
                        inventory.iceCubes.Remove(new IceCube());
                    }
                    if(inventory.cups.Count < 12)
                    {
                        pitcher.cupsLeftInPitcher = inventory.cups.Count;
                    }
                    else
                    {
                        pitcher.cupsLeftInPitcher = 12;
                    }
                }
                else
                {
                    Console.WriteLine("We are sold out");
                }
            }
        }
        public void SellCup(Customer customer)
        {
            //if (customer.ProbabilityToPurchase = true)
            //{
            //    pitcher.cupsLeftInPitcher--;
            //    inventory.cups.Remove(new Cup());
            //}
        }
    }
}
