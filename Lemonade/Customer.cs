using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Customer
    {
        public string name;
        Random random;
        Weather weather;
        public Customer(string name)
        {
            this.name = name;
            List<string> namesList = new List<string>() { "Eva", "Lorine", "Carolee", "Juan", "Parthenia", "Cory",
                                                          "Dung", "Larisa", "Cyndi", "Rubye", "Aja", "Jerrold",
                                                          "Johnette", "April", "Criselda", "Tressa", "Theressa", 
                                                          "Isidro", "Renata", "Danyell", "Perry", "Fe", "Jeremy", 
                                                          "Dionne", "Dessie",  "Toby", "Christiana", "Stanton", "Leona",
                                                          "Barabara", "Buddy", "Lynn", "Freddy", "Numbers", "Mae", 
                                                          "Isela", "Macy", "Alessandra", "Sondra", "Ashlyn", "Jacinda",
                                                          "Erick", "Maryanna", "Thora", "Junita", "Lizeth", "Alena",
                                                          "Mandy", "Lisbeth", "Wendi" };
        }
        // TO DO
        // Implement a price factor, weather and heat factor
        // The price of product as well as weather/temperature should affect demand, 
        // so that if the price is too high, sales will decrease, or if the price is too low, 
        // sales will increase, etc.
        public void ProbabilityToPurchase()
        {
            
        }
        
        
        public void CalculatePriceFactor()
        {

        }
    }
}
