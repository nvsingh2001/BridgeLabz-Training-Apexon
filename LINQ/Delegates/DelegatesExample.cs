namespace LINQ.Delegates;

public class DelegatesExample
{
    public delegate void MyDelegate(string message);
    
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void Run()
    {
        MyDelegate myDelegate = DisplayMessage;
        myDelegate("Hello World!");
    }
}