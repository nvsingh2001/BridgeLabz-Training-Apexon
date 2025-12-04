using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class ReverseString
    {
        /*
         * 1.Reverse a String: Write a function to reverse a given string.
         */
        public static void reverseString()
        {
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();

            if (str != null)
            {
                StringBuilder stringBuilder = new StringBuilder();
                int n = str.Length - 1;

                while (n >= 0)
                {
                    stringBuilder.Append(str[n--]);
                }

                Console.WriteLine(stringBuilder.ToString());
            }
        }
    }
}
