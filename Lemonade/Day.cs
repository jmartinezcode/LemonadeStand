﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Day
    {
        public Weather weather;
        public List<Customer> customers;
        int numberOfCustomers;
        Random random;
        public Day()
        {

            random = new Random(); 
            weather = new Weather();
            customers = new List<Customer>();
            NumberOfGeneratedCustomers();
            GenerateCustomers();
        }

        public void NumberOfGeneratedCustomers()
        {
            // Number of customers varies on weather:            
            switch (weather.condition)
            {
                case "Rain":
                    numberOfCustomers = random.Next(30, 61);
                    break;
                case "Hazy":
                    numberOfCustomers = random.Next(45, 76);
                    break;
                case "Overcast":
                    numberOfCustomers = random.Next(60, 91);
                    break;
                case "Sunny":
                    numberOfCustomers = random.Next(75, 106);
                    break;
            }
        }
        public void GenerateCustomers()
        {
            // Create a List of Customers
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer("Customer"); 
                customer.maxPrice = random.Next(36) / 100.0;
                customer.chanceToBuy = random.Next(2);
                customers.Add(customer);
            }
        }
    }
}
