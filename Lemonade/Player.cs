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
            pitcher = new Pitcher();
            inventory = new Inventory();
            recipe = new Recipe();

        }

        //Member Methods (CAN DO)
        public void FillPitcher()
        {
            while(pitcher.cupsLeftInPitcher == 0)
            {
                if(inventory.lemons.Count >= recipe.amountOfLemons && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && inventory.iceCubes.Count >= recipe.amountOfIceCubes && inventory.cups.Count > 0)
                {
                
                }
                else
                {
                    Console.WriteLine("We are sold out");
                }
            }
        }

    }
}
