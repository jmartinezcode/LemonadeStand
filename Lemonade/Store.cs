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

        //Constructor
        public Store()
        {
            // Set random prices of each item
            pricePerLemon = random.Next(95, 105) / 100.0; 
            pricePerSugarCube = random.Next(3, 10) / 100.0;
            pricePerIceCube = random.Next(2, 4) / 100.0;
            pricePerCup = random.Next(3, 6) / 100.0;
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
    }
}
