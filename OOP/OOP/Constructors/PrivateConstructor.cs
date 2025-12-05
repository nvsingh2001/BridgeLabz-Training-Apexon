using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Constructors
{
    internal class PrivateConstructor
    {
        public int x;

        private PrivateConstructor(int x)
        {
            this.x = x;
        }

        public void display()
        {
            Console.WriteLine(x);
        }

        static public PrivateConstructor getInstance()
        {
            PrivateConstructor innerClass = new PrivateConstructor(10);
            return innerClass;
        }
    }
}
