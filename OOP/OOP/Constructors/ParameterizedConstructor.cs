using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Constructors
{
    internal class ParameterizedConstructor
    {
        public int x;
        public string str;

        public ParameterizedConstructor(int x, string str)
        {
            this.x = x;
            this.str = str;
        }
    }
}
