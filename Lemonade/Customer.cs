using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Customer
    {
        public string name;
        Random random;
        public double maxPrice;
        public double chanceToBuy;
        public Customer(string name)
        {
            random = new Random();
            this.name = name;
            maxPrice = random.Next(36) / 100.0; //Max Price customer is willing to pay randomly generated between 15 and 35 cents           
            chanceToBuy = random.NextDouble();  
        }
    }
}
