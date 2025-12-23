namespace LINQ.Delegates;

public class ReturnDelegates
{
    public delegate int Operation(int x, int y);
    
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;

    public static void Run()
    {
        Operation add = Add;
        Operation sub = Subtract;
        
        Console.WriteLine(add(10, 20));
        Console.WriteLine(sub(10, 20));
    }
}