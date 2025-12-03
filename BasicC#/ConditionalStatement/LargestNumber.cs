using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class LargestNumber
    {
        // C# Program to Find the Largest Among Three Numbers

        public static void largestNumber()
        {
            int num1, num2, num3;
            Console.Write("\nEnter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\nEnter the Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the Second number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int max;

            if(num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if(num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else if(num3 > num1 && num3 > num2)
            {
                max = num3;
            }
            else
            {
                Console.WriteLine("All are equal");
                return;
            }

            Console.WriteLine($"{max} is the largest");
        }
    }
}
