using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class AnagramCheck
    {
        // 3.Anagram Check: Check if two strings are anagrams of each other (contain the same characters in a different order).

        public static Boolean anagramCheck(string s1, string s2)
        {
            if(s1.Length != s2.Length) return false;

            Dictionary<char,int> count = new Dictionary<char,int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (!count.ContainsKey(s1[i])) count[s1[i]] = 1;
                else count[s1[i]]++;

                if (!count.ContainsKey(s2[i])) count[s2[i]] = -1;
                else count[s2[i]]--;
            }

            foreach(var key in count.Keys)
            {
                if (count[key] > 0) return false;
            }

            return true;
        }
    }
}
