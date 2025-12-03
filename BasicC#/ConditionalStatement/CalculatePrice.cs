using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class CalculatePrice
    {
        /*
         * Write a C# program that calculates the price of a movie ticket based on the age of the customer and the time of the movie. 
         * Implement different pricing rules for children (under 12), adults (12-64), and seniors (65+), and consider matinee discounts.
         */

        public static void calculateTicketPrice()
        {
            Console.Write("Enter the movie time(in hours): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter the age of the customer: ");
            int age = int.Parse(Console.ReadLine());

            double price = 0.0;

            if(age < 12)
            {
                price = 100.0;
            }
            else if(age >= 12 && age <= 64)
            {
                price = 200.0;
            }
            else
            {
                price = 150.0;
            }

            if(time < 16)
            {
                price -= 2.0; 
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"The price of the movie ticket is: ₹{price}");
        }
    }
}
