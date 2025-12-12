namespace ExceptionHandling;

class Program
{
    static void A()
    {
        try
        {
            B();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void B(){C();}
    static void C(){ throw new Exception("Boom!");}
    static void Main(string[] args)
    {
        // TryCatch.Divide();
        // MultipleCatchBlock.Divide();
        // FinallyBlockDemo.Demo();
        // CustomException.CustomExceptionClassDemo.Divide();
        // InnerExceptionHandling.Divide();
        // A();
        unchecked
        {
            int x = int.MaxValue + 1;
            Console.WriteLine(x);
        }
    }
}