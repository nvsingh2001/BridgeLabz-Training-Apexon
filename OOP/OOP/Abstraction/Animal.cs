using System;

namespace OOP.Abstraction
{
    internal abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Sleeping....");
        }
    }
}