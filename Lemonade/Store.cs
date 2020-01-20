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

            pricePerLemon = random.Next(95, 105) / 100.0; 
            pricePerSugarCube = random.Next(3, 10) / 100.0;
            pricePerIceCube = random.Next(2, 4) / 100.0;
            pricePerCup = random.Next(3, 6) / 100.0;
            bulkLemonPrice = Math.Round(bulkQty * pricePerLemon, 2);
            bulkSugarPrice = Math.Round(bulkQty * pricePerSugarCube, 2);
            bulkIcePrice = Math.Round(bulkQty * pricePerIceCube, 2);
            bulkCupPrice = Math.Round(bulkQty * pricePerCup, 2);

            //Objects to get name
            //Lemon lemon;
            //SugarCube sugarCube;
            //IceCube iceCube;
            //Cup cup;
        }

        //Member Methods (CAN DO)
        public void BuyLemons(Player player)
        {
            int lemonsBought = Int32.Parse(Console.ReadLine());
            Lemon lemon = new Lemon();
            if (player.wallet.Money > pricePerLemon)
            {
                player.wallet.Money -= pricePerLemon;
                for (int i = 0; i < lemonsBought; i++)
                {
                    player.inventory.lemons.Add(lemon);
                }
            }
        }
        public void BuySugarCubes(Player player)
        {
            int sugarCubesBought = Int32.Parse(Console.ReadLine());
            SugarCube sugarCube = new SugarCube();
            if (player.wallet.Money > pricePerSugarCube)
            {
                player.wallet.Money = -pricePerSugarCube;
                for (int i = 0; i < sugarCubesBought; i++)
                {
                    player.inventory.sugarCubes.Add(sugarCube);
                }
            }
        }
        public void BuyIceCubes(Player player)
        {
            int iceCubesBought = Int32.Parse(Console.ReadLine());
            IceCube iceCube = new IceCube();
            if (player.wallet.Money > pricePerIceCube)
            {
                wallet.Money -= pricePerIceCube;
                for (int i = 0; i < iceCubesBought; i++)
                {
                    player.inventory.iceCubes.Add(iceCube);
                }
            }
        }
        public void BuyCups(Player player)
        {;
            int cupsBought = Int32.Parse(Console.ReadLine());
            Cup cup = new Cup();
            if (wallet.Money > pricePerCup)
            {
                wallet.Money -= pricePerCup;
                for (int i = 0; i < cupsBought; i++)
                {
                    player.inventory.cups.Add(cup);
                }
            }
        }
        public void BuyItems(Player player)
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Lemon lemon = new Lemon();
                    if (player.wallet.Money >= (pricePerLemon * bulkQty))
                    {
                        
                        UserInterface.BuyItem(bulkQty, lemon.name);
                        player.wallet.Money -= (pricePerLemon * bulkQty);                        
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.lemons.Add(lemon);
                        }
                    }
                    else
                    {
                        UserInterface.NotEnoughMoney(lemon.name);
                    }
                    break;
                case "2":
                    SugarCube sugarCube = new SugarCube();
                    if (player.wallet.Money >= (pricePerSugarCube * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, sugarCube.name);
                        player.wallet.Money -= (pricePerSugarCube * bulkQty);                        
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.sugarCubes.Add(sugarCube);
                        }
                    }
                    else
                    {
                        UserInterface.NotEnoughMoney(sugarCube.name);
                    }
                    break;
                case "3":
                    IceCube iceCube = new IceCube();
                    if (player.wallet.Money >= (pricePerIceCube * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, iceCube.name);
                        player.wallet.Money -= (pricePerIceCube * bulkQty);                        
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.iceCubes.Add(iceCube);
                        }
                    }
                    else
                    {
                        UserInterface.NotEnoughMoney(iceCube.name);
                    }
                    break;
                case "4":
                    Cup cup = new Cup();
                    if (player.wallet.Money >= (pricePerCup * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, cup.name);
                        player.wallet.Money -= (pricePerCup * bulkQty);                        
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.cups.Add(cup);
                        }
                    }
                    else
                    {
                        UserInterface.NotEnoughMoney(cup.name);
                    }
                    break;
                default:
                    Console.WriteLine("You did not choose a valid option. Please choose again.");
                    BuyItems(player);
                    break;
            }
        }
    }
}
