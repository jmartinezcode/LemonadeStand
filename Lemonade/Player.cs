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
                while(inventory.lemons.Count > 0 && inventory.sugarCubes.Count > 0 && inventory.iceCubes.Count > 0)
                {
                    if (inventory.lemons.Count >= recipe.amountOfLemons &&
                        inventory.sugarCubes.Count >= recipe.amountOfSugarCubes &&
                        inventory.iceCubes.Count >= recipe.amountOfIceCubes && inventory.lemons.Count > 0 
                        && inventory.iceCubes.Count > 0 && inventory.sugarCubes.Count > 0)
                    {
                        inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
                        inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
                        inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
                        pitcher.cupsLeftInPitcher = 12;
                    }
                    break;
                }
                break;
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
