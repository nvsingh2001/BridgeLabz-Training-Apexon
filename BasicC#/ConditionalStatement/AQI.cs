using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class AQI
    {
        /*
         * 6 Develop a C# program that calculates the Air Quality Index (AQI) based on the concentration of pollutants. 
         * Use conditional statements to classify the AQI into different categories (Good, Moderate, Unhealthy, etc.) 
         * based on predefined thresholds for different pollutants. 
         */
        public static void aqi()
        {
            Console.Write("Enter the concentration of PM2.5 (µg/m³):");
            double pm25 = double.Parse(Console.ReadLine());

            string aqiCategory;
            
            if (pm25 <= 12)
            {
                aqiCategory = "Good";
            }
            else if (pm25 <= 35.4)
            {
                aqiCategory = "Moderate";
            }
            else if (pm25 <= 55.4)
            {
                aqiCategory = "Unhealthy for Sensitive Groups";
            }
            else if (pm25 <= 150.4)
            {
                aqiCategory = "Unhealthy";
            }
            else if (pm25 <= 250.4)
            {
                aqiCategory = "Very Unhealthy";
            }
            else
            {
                aqiCategory = "Hazardous";
            }

            Console.WriteLine($"The AQI category for PM2.5 is: {aqiCategory}");
        }
    }
}
