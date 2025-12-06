namespace OOP.Inheritance
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name){}
        public new void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
}