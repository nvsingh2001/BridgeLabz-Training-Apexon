using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.DataTypes
{
    internal class OddOrEven
    {
        // C# Program to Check Whether a Number is Even or Odd

        public static void checkOddorEven()
        {
            Console.Write("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
