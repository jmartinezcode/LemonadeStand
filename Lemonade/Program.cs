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
            Customer customer = new Customer();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(customer.name);
            }
        }
    }
}
