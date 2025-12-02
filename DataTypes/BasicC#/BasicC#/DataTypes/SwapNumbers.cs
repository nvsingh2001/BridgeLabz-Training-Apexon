using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.DataTypes
{
    internal class SwapNumbers
    {
        // C# Program to Swap Two Numbers

        public static void Swap(ref int a,ref int b)
        {
            if(a == b) { return; }
            a += b;
            b = a - b;
            a = a - b;
        }
    }
}
