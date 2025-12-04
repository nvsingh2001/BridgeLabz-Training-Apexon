using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class PalindromeCheck
    {
        // 2.Palindrome Check: Determine if a given string is a palindrome (reads the same forwards and backwards).
        public static bool check(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i++]!= str[j--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
