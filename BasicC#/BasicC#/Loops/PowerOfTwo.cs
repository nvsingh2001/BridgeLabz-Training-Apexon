using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class PowerOfTwo
    {
        /*   3. Power of 2
         *   a. Desc -> This program takes a command-line argument N and prints a table of the
         *       powers of 2 that are less than or equal to 2^N.
         *   b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
         *   c. Logic -> repeat until i equals N.
         */

        public static void PrintPowersOfTwo()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 0 || N >= 31)
            {
                Console.WriteLine("Please enter a valid power value N (0 <= N < 31).");
                return;
            }
            for (int i = 0; i <= N; i++)
            {
                int powerOfTwo = (int)Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {powerOfTwo}");
            }
        }
    }
}
