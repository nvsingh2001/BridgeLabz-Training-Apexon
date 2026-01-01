namespace Multithreading;

public class ThreadingDemo
{
    public static void Run()
    {
        Console.WriteLine("ThreadingDemo Started");
        Thread t1 = new Thread(Method1){ Name = "Thread1" };
        Thread t2 = new Thread(Method2){ Name = "Thread2" };
        Thread t3 = new Thread(Method3){ Name = "Thread3" };
        
        // Executing the methods
        t1.Start();
        t2.Start();
        t3.Start();
        
        t1.Join();
        t2.Join();
        t3.Join();
        
        Console.WriteLine("ThreadingDemo Finished");
    }
    
    static void Method1()
    {
        Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method1: {i}");
        }
        Console.WriteLine("Method1 Finished using " + Thread.CurrentThread.Name );
    }
    
    static void Method2() {
        Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method2: {i}");
            if (i == 6)
            {
                Console.WriteLine($"Performing I/O operation");
                
                // Sleep for 10 Seconds
                Thread.Sleep(10000);
                Console.WriteLine($"Completed I/O operation");
            }
        }
        Console.WriteLine("Method2 Finished using " + Thread.CurrentThread.Name );
    }

    static void Method3()
    {
        Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method3: {i}");
        }
        Console.WriteLine("Method3 Finished using " + Thread.CurrentThread.Name );
    }
}
