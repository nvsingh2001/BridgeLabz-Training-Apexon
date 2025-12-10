namespace OOP.Polymorphism
{
    internal class MethodOverLoading
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(String a, String b)
        {
            Console.WriteLine(a + b);
        }
    }
}