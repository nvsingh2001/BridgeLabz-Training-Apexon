namespace OOP.Polymorphism.OperatorOverloading
{
    internal class Complex
    {
        private int real;
        private int img;

        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }

        public static Complex operator + (Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.img + b.img);
        }

        public override string ToString()
        {
            return $"{real} + i{img}";
        }
    }
}