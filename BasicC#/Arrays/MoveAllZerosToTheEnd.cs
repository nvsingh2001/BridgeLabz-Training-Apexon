using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Arrays
{
    internal class MoveAllZerosToTheEnd
    {
        public static void moveAllZeros(int[] array)
        {
            int pos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[pos++] = array[i];
                }
            }
            for(int i = pos; i < array.Length; i++)
            {
                array [i] = 0;
            }
        }
    }
}
