using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class Factors
    {
        /*
         *  5. Factors
         *  a. Desc -> Computes the prime factorization of N using brute force.
         *  b. I/P -> Number to find the prime factors
         *  c. Logic -> Traverse till i*i <= N instead of i <= N for efficiency.
         *  d. O/P -> Print the prime factors of number N.
         */

        public static void PrintPrimeFactors()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 1)
            {
                Console.WriteLine("Please enter a valid number greater than 1.");
                return;
            }

            Console.Write($"Prime factors of {N} are: ");

            for (int i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.Write(i + " ");
                    N /= i;
                }
            }
        }
    }
}
