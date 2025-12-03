using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class CouponNumbers
    {
        /*
         *  5. Coupon Numbers
         *  a. Desc -> Given N distinct Coupon Numbers, how many random numbers do you
         *  need to generate a distinct coupon number? This program simulates this random
         *  process.
         *  b. I/P -> N Distinct Coupon Number
         *  c. Logic -> repeatedly choose a random number and check whether it's a new one.
         *  d. O/P -> total random number needed to have all distinct numbers.
         *  e. Functions => Write Class Static Functions to generate random numbers and to
         *  process distinct coupons. 
         */

        static int N;

        static int randomNumberGenerator()
        {
            var random = new Random();
            return random.Next(1,N + 1);
        }

        public static void couponNumbers()
        {
            Console.Write("Enter the number of distinct coupon numbers: ");

            N = int.Parse(Console.ReadLine());
            bool[] visited = new bool[N + 1];

            int numOfVisitedNumbers = 0;

            int numOfTries = 0;

            while(numOfVisitedNumbers != N)
            {
                int randomNum = randomNumberGenerator();
                if (!visited[randomNum])
                {
                    visited[randomNum] = true;
                    numOfVisitedNumbers++;
                }
                numOfTries++;
                Console.WriteLine(numOfVisitedNumbers + " " + numOfTries);
            }

            Console.WriteLine($"Total numbers of random needed: {numOfTries}");
        }
    }
}
