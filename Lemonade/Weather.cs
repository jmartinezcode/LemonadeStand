using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions;
        public string predictedForecast;
        Random random;
        public Weather()
        {
            random = new Random();
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Hazy", "Rain" };
            SetTemperature();
            SetCondition(GenerateRandomIndex());
            SetForecast();
        }

        public void SetTemperature()
        {
            // Set Temperature randomly between 50 and 100 degrees            
            temperature = random.Next(50, 101);
        }
        public void SetCondition(int index)
        {
            // Randomly pull from weatherConditions List
            condition = weatherConditions[index];
        }
        public void SetForecast()
        {
            // Takes output from SetCondition and SetTemperature to output predictedForecast
            int temperatureVariance = random.Next(-7, 8);
            predictedForecast = (temperature + temperatureVariance) + " degrees and " + condition;
        }
        public int GenerateRandomIndex()
        {
            return random.Next(weatherConditions.Count);
        }


    }
}
