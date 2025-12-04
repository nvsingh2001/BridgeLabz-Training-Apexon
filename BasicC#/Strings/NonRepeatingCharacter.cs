using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class NonRepeatingCharacter
    {
        // 6.Find the First Non-Repeating Character: Given a string, find the first character that is not repeated anywhere in the string.

        public static char nonReapeatingCharacter(string str)
        {
            str = str.Trim().ToLower();
            Dictionary<char,int> freq = new Dictionary<char,int>();

            foreach (char c in str)
            {
                if(freq.ContainsKey(c)) freq[c]++;
                else freq[c] = 1;
            }

            foreach (char c in freq.Keys)
            {
                if (freq[c] == 1) return c;
            }

            return '\0';
        }
    }
}
