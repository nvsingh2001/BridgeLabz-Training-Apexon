using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Constructors
{
    internal class StaticConstructor
    {
        public static int xStatic;
        public static string strStatic;
        public int x;
        public string str;

        static StaticConstructor()
        {
            xStatic = 10;
            strStatic = "Static String";
        }

        public StaticConstructor(int x, string str)
        {
            this.x = x;
            this.str = str;
        }
    }
}
