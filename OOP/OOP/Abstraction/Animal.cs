using System;

namespace OOP.Abstraction
{
    internal abstract class Animal
    {
        private string _name;

        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Sleeping....");
        }
    }
}