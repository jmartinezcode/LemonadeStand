using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Wallet
    {
        //Member Variables (HAS A)
        double money = 20;
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (money <= 0)
                {
                    money = 0;
                }
            }
        }

        //Constructor

        //Member Methods (CAN DO)

    }
}
