using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class LongestSubstringWithoutRepeatation
    {
        // 4.Longest Substring Without Repeating Characters:
        // Find the length of the longest substring in a given string without repeating characters.

        public static int LongestSubstring(string str)
        {
            int i = 0;
            int j = 0;

            bool[] visited = new bool[26];

            str = str.ToLower();

            int length = 0;

            while (j < str.Length)
            {
                int c = str[j] - 'a';
                while (visited[c])
                {
                    int charAtI = str[i] - 'a';
                    visited[charAtI] = false;
                    i++;
                }
                visited[c] = true;
                length = Math.Max(length, j - i + 1);
                j++;
            }
            return length;
        }
    }
}
