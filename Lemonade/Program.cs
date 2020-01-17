using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                double pricePerIceCube = random.Next(2, 4) / 100.0;
                Console.WriteLine(pricePerIceCube);
            }
            Console.ReadLine();
        }
    }
}
