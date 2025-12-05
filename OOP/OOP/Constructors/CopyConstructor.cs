using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Constructors
{
    internal class CopyConstructor
    {
        public int x;
        public string str;

        public CopyConstructor(int x, string str)
        {
            this.x = x;
            this.str = str;
        }

        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
            str = obj.str;
        }
    }
}
