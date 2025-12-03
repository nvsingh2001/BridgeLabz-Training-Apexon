using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class ReverseNumber
    {
        /*
          4. Reverse a number
            In C#, we can reverse a number either by using for loop, while loop, or using recursion.
               The simplest way to reverse a number is by using for loop or while loop. In order to
                reverse a number, we have to follow the following steps:
            a. We need to calculate the remainder of the number using the modulo
            b. After that, we need to multiply the variable reverse by 10 and add the remainder into
                it.
            c. We then divide the number by 10 and repeat steps until the number becomes 0.

         */
        public static void reverseNumber()
        {
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0) 
            { 
                Console.WriteLine("Number should be greater than equal 0");
            }

            int revNum = 0;

            while(num > 0)
            {
                revNum = 10 * revNum +  num % 10;
                num /= 10;
            }

            Console.WriteLine($"Reverse of the number: {revNum}");
        }
    }
}
