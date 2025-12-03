using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class PrimeNumber
    {
        public static void primeNumber()
        {
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());

            if(num < 2)
            {
                Console.WriteLine($"{num} is not a prime number");
                return;
            }

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine($"{num} is not a prime number.");
                    return;
                }
            }

            Console.WriteLine($"{num} is a prime number");
        } 
    }
}
