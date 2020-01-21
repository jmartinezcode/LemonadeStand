using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Store
    {
        //Member Variables (HAS A)
        double pricePerLemon;
        double pricePerSugarCube;
        double pricePerIceCube;
        double pricePerCup;
        Random random;
        Wallet wallet;
        int bulkQty;

        public double bulkLemonPrice;
        public double bulkSugarPrice;
        public double bulkIcePrice;
        public double bulkCupPrice;


        //Constructor
        public Store()
        {
            // Set random prices of each item

            random = new Random();
            bulkQty = 5;

            pricePerLemon = random.Next(15, 65) / 100.0; 
            pricePerSugarCube = random.Next(3, 10) / 100.0;
            pricePerIceCube = random.Next(2, 4) / 100.0;
            pricePerCup = random.Next(3, 6) / 100.0;
            bulkLemonPrice = Math.Round(bulkQty * pricePerLemon, 2);
            bulkSugarPrice = Math.Round(bulkQty * pricePerSugarCube, 2);
            bulkIcePrice = Math.Round(bulkQty * pricePerIceCube, 2);
            bulkCupPrice = Math.Round(bulkQty * pricePerCup, 2);
        }

        //Member Methods (CAN DO)
        public void BuyLemons(Player player)
        {
            Lemon lemon = new Lemon();
            if (player.wallet.Money >= pricePerLemon * bulkQty)
            {
                UserInterface.BuyItem(bulkQty, lemon.name);
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.lemons.Add(lemon);
                    player.wallet.Money -= pricePerLemon;
                }
            }
            else
            {
                UserInterface.NotEnoughMoney(lemon.name);
            }
        }
        public void BuySugarCubes(Player player)
        {
            SugarCube sugarCube = new SugarCube();
            if (player.wallet.Money >= pricePerSugarCube * bulkQty)
            {
                UserInterface.BuyItem(bulkQty, sugarCube.name);
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.sugarCubes.Add(sugarCube);
                    player.wallet.Money -= pricePerSugarCube;
                }
            }
            else
            {
                UserInterface.NotEnoughMoney(sugarCube.name);
            }
        }
        public void BuyIceCubes(Player player)
        {
            IceCube iceCube = new IceCube();
            if (player.wallet.Money >= pricePerIceCube * bulkQty)
            {
                UserInterface.BuyItem(bulkQty, iceCube.name);
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.iceCubes.Add(iceCube);
                    player.wallet.Money -= pricePerIceCube;
                }
            }
            else
            {
                UserInterface.NotEnoughMoney(iceCube.name);
            }
        }
        public void BuyCups(Player player)
        {
            Cup cup = new Cup();
            if (wallet.Money >= pricePerCup * bulkQty)
            {
                UserInterface.BuyItem(bulkQty, cup.name);
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.cups.Add(cup);
                    player.wallet.Money -= pricePerCup;
                }
            }
            else
            {
                UserInterface.NotEnoughMoney(cup.name);
            }
        }
    }
}
