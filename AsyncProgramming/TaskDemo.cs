namespace AsyncProgramming;

using System; 
using System.Threading.Tasks;

public class TaskDemo 
{
    public static async Task Main()
    {
        Task<int> task = Task.Run(() => SlowAdd(3, 5));
        int result = await task;           // Asynchronously wait
        Console.WriteLine(result);         // Prints 8
    }

    static int SlowAdd(int a, int b)
    {
        Task.Delay(1000).Wait();           // Simulate work
        return a + b;
    }
}
