using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.DataTypes
{
    internal class QuotientandRemainder
    {
        // C# Program to Compute Quotient and Remainder
        public static void CalculateQuotientAndRemainder()
        {
            Console.Write("Enter the dividend (numerator): ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor (denominator): ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            if (divisor == 0)
            {
                Console.WriteLine("\nError: Division by zero is not allowed.");
                return;
            }
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }
    }
}
