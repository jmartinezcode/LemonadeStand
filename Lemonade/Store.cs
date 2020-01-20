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
            else
            {
                UserInterface.NotEnoughMoney(lemon.name);
            }
        }
        public void BuySugarCubes(Player player)
        {
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
            else
            {
                UserInterface.NotEnoughMoney(sugarCube.name);
            }
        }
        public void BuyIceCubes(Player player)
        {
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
            else
            {
                UserInterface.NotEnoughMoney(iceCube.name);
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
                    Lemon lemon = new Lemon();
                    if (wallet.Money >= (pricePerLemon * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.lemons[0].name);
                        wallet.Money -= (pricePerLemon * bulkQty);
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
                    if (wallet.Money >= (pricePerSugarCube * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.sugarCubes[0].name);
                        wallet.Money -= (pricePerSugarCube * bulkQty);
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
                    if (wallet.Money >= (pricePerIceCube * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.iceCubes[0].name);
                        wallet.Money -= (pricePerIceCube * bulkQty);
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
                    if (wallet.Money >= (pricePerCup * bulkQty))
                    {
                        UserInterface.BuyItem(bulkQty, player.inventory.cups[0].name);
                        wallet.Money -= (pricePerCup * bulkQty);
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
                    {
                        UserInterface.NotAValidOption();
                    }
                    break;
            }
        }
    }
}
