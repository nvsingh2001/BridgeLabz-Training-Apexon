using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class LeapYear
    {
        /*
         * 2. Leap Year
         * a. I/P -> Year, ensure it is a 4 digit number.
         * b. Logic -> Determine if it is a Leap Year.
         * c. O/P -> Print the year is a Leap Year or not.
         */

        public static void CheckLeapYear()
        {
            int year = Convert.ToInt32(Console.ReadLine());

            if(year < 1000 || year > 9999)
            {
                Console.WriteLine("Please enter a valid 4 digit year.");
                return;
            }

            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}
