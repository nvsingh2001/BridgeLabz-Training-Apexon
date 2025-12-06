namespace OOP.Inheritance
{
    interface IFather
    {
        public string Name { get; }
    }

    interface IMother
    {
        public string Name { get; }
    }
    
    public class Multiple : IFather,IMother
    {
        public string Name => "Multiple";
    }
}