namespace OOP.Polymorphism
{
    class class1
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
    }
    internal class InheritanceOverloading : class1
    {
        public void add(string a, string b){
            Console.WriteLine(a + b);
        }
    }
}