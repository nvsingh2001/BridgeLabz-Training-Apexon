using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class KmpSearch
    {
        public static int[] buildLPS(string pattern)
        {
            int m = pattern.Length;
            int[] LPS = new int[m];
            int length = 0;
            int i = 1;
            LPS[0] = 0;

            while(i < m)
            {
                if (pattern[i] == pattern[length])
                {
                    length++;
                    LPS[i++] = length;
                }
                else 
                {
                    if(length != 0) 
                    {
                        length = LPS[length - 1];
                    }
                    else
                    {
                        LPS[i] = 0;
                        i++;
                    }
                }
            }

            return LPS;
        }

        public static bool search(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            int[] lps = buildLPS(pattern);

            int i, j;
            i = j = 0;

            while (i < n)
            {
                if (text[i] == pattern[j])
                {
                    i++;
                    j++;

                    if (j == m)
                    {
                        return true;
                    }
                }
                else
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return false;
        }
    }
}
