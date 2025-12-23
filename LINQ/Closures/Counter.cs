namespace LINQ.Closures;

public class Counter
{
    private static Func<int> CreateCounter()
    {
        int count = 0;
        return () => count++;
    }

    public static void Run()
    {
        Func<int> counter = CreateCounter();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(counter());
        }
    }
}