namespace OOP.Abstraction
{
    internal class Circle(double radius) : IShape
    {
        private double Radius { get; } = radius;
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}