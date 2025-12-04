using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Strings
{
    internal class CompressString
    {
        // 5.String Compression: Implement a method to compress a string using counts of repeated characters (e.g., "aaabb" becomes "a3b2").

        public static String compressString(string str)
        {
            Dictionary<char,int> count = new Dictionary<char,int>();
            StringBuilder sb = new StringBuilder();

            count[str[0]] = 1;
            for( int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    sb.Append(str[i - 1]);
                    sb.Append(count[str[i - 1]]);
                    count[str[i - 1]] = 0;
                }
                if (!count.ContainsKey(str[i])) count[str[i]] = 1;
                else count[str[i]]++;
            }

            sb.Append(str[str.Length -1]);
            sb.Append(count[str[str.Length - 1]]);

            return sb.ToString();
        }
    }
}
