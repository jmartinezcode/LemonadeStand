using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Store
    {
        //Member Variables (HAS A)
        double pricePerLemon;
        double pricePerSugarCube;
        double pricePerIceCube;
        double pricePerCup;
        Random random;

        public int bulkQty;
        public double bulkLemonPrice;
        public double bulkSugarPrice;
        public double bulkIcePrice;
        public double bulkCupPrice;
        
        //Constructor
        public Store()
        {
            // Set random prices of each item

            random = new Random();
            bulkQty = 10;

            pricePerLemon = random.Next(150, 340) / 1000.0; 
            pricePerSugarCube = random.Next(15, 50) / 1000.0;
            pricePerIceCube = random.Next(10, 40) / 1000.0;
            pricePerCup = random.Next(10, 20) / 1000.0;
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
                player.wallet.Money -= bulkLemonPrice;
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.lemons.Add(lemon);
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
                player.wallet.Money -= bulkSugarPrice;
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.sugarCubes.Add(sugarCube);
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
                player.wallet.Money -= bulkIcePrice;
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.iceCubes.Add(iceCube);
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
            if (player.wallet.Money >= pricePerCup * bulkQty)
            {
                UserInterface.BuyItem(bulkQty, cup.name);
                player.wallet.Money -= bulkCupPrice;
                for (int i = 0; i < bulkQty; i++)
                {
                    player.inventory.cups.Add(cup);
                }
            }
            else
            {
                UserInterface.NotEnoughMoney(cup.name);
            }
        }
    }
}
