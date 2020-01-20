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
        }

        //Member Methods (CAN DO)
        public void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int lemonsBought = Int32.Parse(Console.ReadLine());
            Lemon lemon = new Lemon();
            if (wallet.Money > pricePerLemon)
            {
                wallet.Money -= pricePerLemon;
                for (int i = 0; i < lemonsBought; i++)
                {
                    player.inventory.lemons.Add(lemon);
                }
            }
        }
        public void BuySugarCubes(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int sugarCubesBought = Int32.Parse(Console.ReadLine());
            SugarCube sugarCube = new SugarCube();
            if (wallet.Money > pricePerSugarCube)
            {
                wallet.Money = -pricePerSugarCube;
                for (int i = 0; i < sugarCubesBought; i++)
                {
                    player.inventory.sugarCubes.Add(sugarCube);
                }
            }
        }
        public void BuyIceCubes(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int iceCubesBought = Int32.Parse(Console.ReadLine());
            IceCube iceCube = new IceCube();
            if (wallet.Money > pricePerIceCube)
            {
                wallet.Money -= pricePerIceCube;
                for (int i = 0; i < iceCubesBought; i++)
                {
                    player.inventory.iceCubes.Add(iceCube);
                }
            }
        }
        public void BuyCups(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
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
                    if (wallet.Money >= (pricePerLemon * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.lemons[0].name);
                        wallet.Money -= (pricePerLemon * bulkQty);
                        Lemon lemon = new Lemon();
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.lemons.Add(lemon);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money to make that purchase.");
                    }
                    break;
                case "2":
                    if (wallet.Money >= (pricePerSugarCube * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.sugarCubes[0].name);
                        wallet.Money -= (pricePerSugarCube * bulkQty);
                        SugarCube sugarCube = new SugarCube();
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.sugarCubes.Add(sugarCube);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money to make that purchase.");
                    }
                    break;
                case "3":
                    if (wallet.Money >= (pricePerIceCube * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.iceCubes[0].name);
                        wallet.Money -= (pricePerIceCube * bulkQty);
                        IceCube icecube = new IceCube();
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.iceCubes.Add(icecube);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money to make that purchase.");
                    }
                    break;
                case "4":
                    if (wallet.Money >= (pricePerCup * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.cups[0].name);
                        wallet.Money -= (pricePerCup * bulkQty);
                        Cup cup = new Cup();
                        for (int i = 0; i < bulkQty; i++)
                        {
                            player.inventory.cups.Add(cup);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money to make that purchase.");
                    }
                    break;
                default:
                    Console.WriteLine("You did not choose a valid option. Please choose again.");
                    break;
            }
        }
    }
}
