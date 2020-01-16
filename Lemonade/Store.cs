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

        //Constructor
        public Store()
        {
            pricePerLemon = (random.Next(95, 105) / 100);
            pricePerSugarCube = (random.Next(5, 10) / 100);
            pricePerIceCube = (random.Next(2, 4) / 100);
            pricePerCup = (random.Next(3, 6) / 100);
        }

        //Member Methods (CAN DO)


    }
}
