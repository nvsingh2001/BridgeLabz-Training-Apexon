namespace LINQ.Delegates;

public class MultiCastDelegates
{
    public delegate void Notify();

    public static void MethodA() => Console.WriteLine("Method A executed");
    public static void MethodB() => Console.WriteLine("Method B executed");

    public static void Run()
    {
        Notify notify = MethodA;
        notify += MethodB;

        notify(); 
    }
}