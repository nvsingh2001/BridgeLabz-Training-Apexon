using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class ConvertTemperature
    {
        /*
         * 2
            Develop a C# program that converts temperatures between Fahrenheit and Celsius based on user input. 
            Use conditional statements to determine the conversion formula based on the user's choice.
         */
        private static double convertToFahrenheit(double tempInCelsius)
        {
            return (tempInCelsius * (double)9 / (double)5) + 32;
        }

        private static double convertToCelcius(double tempInFahrenheit) {
            return (double)5 / (double) 9 * (tempInFahrenheit - 32);
        }

        public static void convertTemperature()
        {
            Console.Write("Enter the temperature: ");
            double temp = double.Parse(Console.ReadLine());

            Console.Write("Enter the unit(c/f): ");
            char unit = char.Parse(Console.ReadLine()); 

            if(!(unit != 'c' || unit != 'f'))
            {
                Console.WriteLine("Invalid Unit");
                return;
            }

            if(unit == 'c')
            {
                Console.WriteLine($"Temperature in Fahrenheit: {convertToFahrenheit(temp)}");
            }
            else
            {
                Console.WriteLine($"Temperature in Celsius: {convertToCelcius(temp)}");
            }

        }


    }
}
