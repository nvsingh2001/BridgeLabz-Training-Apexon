namespace Multithreading;

public class SemaphoreDemo
{
    private static Semaphore _semaphore = new Semaphore(2, 3);

    public static void Run()
    {
        for (int i = 1; i <= 10; i++)
        {
            Thread threadObject = new(DoSomeTask){Name = $"Thread{i}"};
            threadObject.Start();
        }
    }
    
    static void DoSomeTask()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} Wants to Enter into Critical Section for Processing");

        try
        {
            _semaphore.WaitOne();
            Console.WriteLine($"Success: {Thread.CurrentThread.Name} is Doing its work");
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.Name + " Exit. ");
        }
        finally
        {
            _semaphore.Release();
        }
    }
}