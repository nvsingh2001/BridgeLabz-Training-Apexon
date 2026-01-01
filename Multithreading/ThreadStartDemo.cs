namespace Multithreading;

public class ThreadStartDemo
{
    static void DisplayNumbersUptoMax(object max)
    {
        int maxInt =  (int)max;
        foreach (int i in Enumerable.Range(0, maxInt))
        {
            Console.WriteLine(i);
        }
    }
    public static void Run()
    {
        // ThreadStart obj = new ThreadStart(DisplayNumbers);
        // Thread t = new Thread(obj);

        ParameterizedThreadStart ptsd = new ParameterizedThreadStart(DisplayNumbersUptoMax);
        var t = new Thread(ptsd);
        
        t.Start(5);
        Console.ReadLine();
    }
    static void DisplayNumbers()
    {
        foreach (int i in Enumerable.Range(0, 10))
        {
            Console.WriteLine(i);
        }
    }

}