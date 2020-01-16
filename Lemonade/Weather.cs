using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions;
        public string predictedForecast;
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Hazy", "Rain" };
        }

        public void SetTemperature()
        {
            // Set Temperature randomly between 50 and 100 degrees
        }
        public void SetCondition()
        {
            // Randomly pull from weatherConditions List
        }
        public void SetForecast()
        {
            // Takes output from SetCondition and SetTemperature to output predictedForecast
        }


    }
}
