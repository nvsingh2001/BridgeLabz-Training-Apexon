namespace OOP.Polymorphism
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void show()
        {
            Console.WriteLine("B");
        }
        
    }
    
    internal class MethodOverRiding
    {
        public static  B GetB()
        {
            return new B();
        }
    }
}