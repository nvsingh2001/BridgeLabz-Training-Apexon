namespace Multithreading;

public class MutexDemo
{
    private static Mutex _mutex = new();

    public static void Run()
    {
        for (int i = 1; i < 5; i++)
        {
            Thread threadObject = new(Demo){Name = "Thread " + i};
            threadObject.Start();
        }
    }
    static void Demo()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} wants to enter crititcal section for processing");
        try
        {
            _mutex.WaitOne();
            Console.WriteLine($"Success: {Thread.CurrentThread.Name} is Processing Now");
            Thread.Sleep(5000);
            Console.WriteLine($"Exit: {Thread.CurrentThread.Name} is Completed its task");
        }
        finally
        {
            _mutex.ReleaseMutex();
        }
    }
}