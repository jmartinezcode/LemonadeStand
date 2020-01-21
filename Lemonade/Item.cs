using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    abstract class Item
    {

        //Liskov's Principle Example Below: We used Liskov's principle throughout this project as you can easily
        //exchange each specific item with the Item Class and the functionality will be the same and they all 
        //have the same property of name.
        public string name;
        public Item()
        {

        }
    }
}
