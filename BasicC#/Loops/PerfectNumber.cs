using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class PerfectNumber
    {
        /*
         * 2. Perfect Number
         * a. Just like the Armstrong number, the Perfect Number is also a special type of
         * positive number. When the number is equal to the sum of its positive divisors
         * excluding the number, it is called a Perfect Number. For example, 28 is the perfect
         * number because when we sum the divisors of 28, it will result in the same number.
         * The divisors of 28 are 1, 2, 4, 7, and 14. So,
         * b. 28 = 1+2+4+7
         * c. 28 = 28
         */

        public static void perfectNumber()
        {
            Console.Write("Enter your number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n <= 0)
            {
                Console.WriteLine("Not a prefect number");
            }

            int sumOfDivisors = 0;

            for(int i = 1; i <= n / 2; i++)
            {
                if(n % i == 0)
                {
                    sumOfDivisors += i;    
                }
            }

            if(sumOfDivisors == n)
            {
                Console.WriteLine($"{n} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{n} is not a perfect number");
            }
        }
    }
}
