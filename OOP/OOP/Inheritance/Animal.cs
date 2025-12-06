namespace OOP.Inheritance
{
    internal  class Animal
    {
        public string Name{get;set;}

        public Animal(string name)
        {
            Name = name;
        }
        
        public void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping....");
        }
    }
}