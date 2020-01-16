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
        public void FillPitcher(Inventory inventory)
        {
            while(pitcher.cupsLeftInPitcher == 0)
            {
            }
        }

    }
}
