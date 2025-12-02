using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class HarmonicNumber
    {
        /*
         * 4. Harmonic Number
         * a. Desc -> Prints the Nth harmonic number: 1/1 + 1/2 + ... + 1/N
                (http://users.encs.concordia.ca/~chvatal/notes/harmonic.html).
         * b. I/P -> The Harmonic Value N. Ensure N != 0
         * c. Logic -> compute 1/1 + 1/2 + 1/3 + ... + 1/N
         * d. O/P -> Print the Nth Harmonic Value.
         */

        public static void PrintHarmonicNumber()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Please enter a valid harmonic value N (N > 0).");
                return;
            }

            double harmonicNumber = 0.0;

            for (int i = 1; i <= N; i++)
            {
                harmonicNumber += 1.0 / i;
            }

            Console.WriteLine($"The {N}th Harmonic Number is: {harmonicNumber}");
        }
    }
}
