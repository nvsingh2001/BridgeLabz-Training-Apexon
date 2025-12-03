using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class FineOnBooks
    {
        /*
         * 8 Design a C# program that calculates the fine for overdue library books. 
         * The program should take the number of days a book is overdue as input and apply different fine rates based on predefined rules 
         * (e.g., first 7 days free, after that $0.50 per day).
         */

        public static void fineOnBooks()
        {
            Console.Write("Enter the number of days the book is overdue: ");
            int daysOverdue = int.Parse(Console.ReadLine());

            double fine = 0.0;

            for(int day = 0; day < daysOverdue; day++) {
                if (day > 7)
                {
                    fine += 0.50;
                }
            }
            Console.WriteLine($"Total fine: ${fine}");
        }
    }
}
