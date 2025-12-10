namespace OOP.Polymorphism
{
    sealed class classA
    {
        public int a { get; set; }
    }

    class ClassB
    {
        private int a = 10;

        public virtual void show()
        {
            Console.WriteLine(a);
        }  
    }

    class classC : ClassB
    {
        private int b = 20;
        public sealed override void show()
        {
            base.show();
            Console.WriteLine(b);
        }
    }

    class classD : classC
    {
        public new void show()
        {
            Console.WriteLine(50);
        }
    }
    
    internal class SealedClass : ClassB
    {
        private int c = 30;
        classA classA = new classA();

        public override void show()
        {
            Console.WriteLine(c);
        }
    }
}