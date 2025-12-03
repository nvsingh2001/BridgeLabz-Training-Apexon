using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class MergeSortedArrays
    {
        public static int[] merge(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while(i <  a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    result[k++] = a[i++];
                }
                else
                {
                    result[k++] = b[j++];
                }
            }

            while(i < a.Length)
            {
                result[k++] = a[i++];
            }

            while(j < b.Length)
            {
                result[k++] = b[j++];
            }

            return result;
        }
    }
}
