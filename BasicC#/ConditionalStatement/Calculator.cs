using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class Calculator
    {
        /*
         * 5 Implement a menu-driven calculator in C# that allows users to perform basic operations (addition, subtraction, multiplication, division). 
         * Use conditional statements to execute the selected operation and handle invalid inputs.
         */

        public static void calculator()
        {
            do
            {
                Console.WriteLine("Calculator:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5) return;

                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Denominator cannot be zero.");
                            return;
                        }
                        result = num1 / num2;
                        Console.WriteLine($"Result: {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (true);
        }
    }
}
