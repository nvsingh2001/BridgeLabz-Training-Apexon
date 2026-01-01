namespace Multithreading;

public class ThreadPoolDemo
{
    public static void Run()
    {
        for (int i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            Console.Read();
        }
    }
    
    static void MyMethod(object obj)
    {
        var thread = Thread.CurrentThread;

        var message =
            $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
        Console.WriteLine(message);
    }
}