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
            int lemonsBought = Int32.Parse(Console.ReadLine());
            Lemon lemon = new Lemon();
            if (player.wallet.Money > pricePerLemon)
            {
                for (int i = 0; i < lemonsBought; i++)
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
            int sugarCubesBought = Int32.Parse(Console.ReadLine());
            SugarCube sugarCube = new SugarCube();
            if (player.wallet.Money > pricePerSugarCube)
            {                
                for (int i = 0; i < sugarCubesBought; i++)
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
            int iceCubesBought = Int32.Parse(Console.ReadLine());
            IceCube iceCube = new IceCube();
            if (player.wallet.Money > pricePerIceCube)
            {
                for (int i = 0; i < iceCubesBought; i++)
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
            int cupsBought = Int32.Parse(Console.ReadLine());
            Cup cup = new Cup();
            if (wallet.Money > pricePerCup)
            {
                for (int i = 0; i < cupsBought; i++)
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
        public void BuyItems(Player player)
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    BuyLemons(player);
                    break;
                case "2":
                    BuySugarCubes(player);
                    break;
                case "3":
                    BuyIceCubes(player);
                    break;
                case "4":
                    BuyCups(player);
                    break;
                case "5":
                    UserInterface.DisplayRecipe(player.recipe.amountOfLemons, player.inventory.lemons.Count,
                         player.recipe.amountOfSugarCubes, player.inventory.sugarCubes.Count, player.recipe.amountOfIceCubes,
                         player.inventory.iceCubes.Count, player.recipe.pricePerCup);
                    break;
                default:
                    {
                        UserInterface.NotAValidOption();
                        BuyItems(player);
                        break;
                    }
            }
        }
    }
}
