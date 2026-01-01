namespace Multithreading;

public class SemaphoreSlimDemo
{
    private static SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(0, 3);

    private static int _padding;

    public static void Run()
    {
        Console.WriteLine($"{_semaphoreSlim.CurrentCount} tasks can enter the semaphore");

        var tasks = new Task[5];

        for (int i = 0; i <= 4; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                Console.WriteLine($"Task {Task.CurrentId} begins and waits for the semaphore");
                int semaphoreCount;
                _semaphoreSlim.Wait();
                try
                {
                    Interlocked.Add(ref _padding, 100);
                    Console.WriteLine($"Task {Task.CurrentId} enters the semaphore");
                    Thread.Sleep(1000 + _padding);
                }
                finally
                {
                    semaphoreCount = _semaphoreSlim.Release();
                }
                Console.WriteLine($"Task {Task.CurrentId} releases the semaphore; previous count: {semaphoreCount}");
            });
        }
        
        Thread.Sleep(1000);
        
        Console.Write("Main thread calls Release(3) -->");
        _semaphoreSlim.Release(3);
        
        Console.WriteLine($"{_semaphoreSlim.CurrentCount} tasks are enter the semaphore");
        
        Task.WaitAll(tasks);
        
        Console.WriteLine($"Main thread Exits");
    }
}