namespace OOP.Inheritance
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent's Constructor Called!");
        }
    }
    
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child's Constructor Called!");
        }
    }

    class GrandChildren : Child
    {
        public GrandChildren()
        {
            Console.WriteLine("GrandChildren Constructor Called!");
        }
    }
    
    public class MultiLevel
    {
        GrandChildren grandChildren = new GrandChildren();
    }
}