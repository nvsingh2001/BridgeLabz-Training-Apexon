using System.ComponentModel.DataAnnotations;

namespace OOP.Polymorphism
{
    class S
    {
        public static int i = 10;
        public static void Display()
        {
            Console.WriteLine("s's display is called");
        }
    }

    class sB
    {
        public static new void Display()
        {
            S.Display();
        }
    }
    
    public class StaticClass
    {
    }
}