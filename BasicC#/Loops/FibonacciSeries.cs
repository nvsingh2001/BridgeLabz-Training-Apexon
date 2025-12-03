using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class FibonacciSeries
    {
        public static void fibonacciSeries()
        {
            Console.Write("Enter the number of the terms of the series: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if(n < 1)
            {
                Console.WriteLine("Not a valid number");
            }
            if(n == 1)
            {
                Console.WriteLine(0);
                return; 
            }

            int prev = 0;
            int next = 1;

            Console.Write(prev + " " +  next + " ");

            for(int i = 3; i <= n; i++)
            {
                int temp = prev;
                prev = next;
                next = temp + next;
                Console.Write(next + " ");
            }
        }
    }
}
