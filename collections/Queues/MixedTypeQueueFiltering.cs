using System.Collections;

namespace collections.Queues;

public class MixedTypeQueueFiltering
{
    static Queue queue = new Queue();

    static MixedTypeQueueFiltering()
    {
        queue.Enqueue(10);
        queue.Enqueue("hello");
        queue.Enqueue(20);
        queue.Enqueue("world");
        queue.Enqueue(30);
    }

    public static void DisplayQueue()
    {
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }

    public static void Filter()
    {
        Queue tempQueue = new Queue();
        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            if (item is int)
            {
                tempQueue.Enqueue(item);
            }
        }

        while (tempQueue.Count > 0)
        {
            queue.Enqueue(tempQueue.Dequeue());
        }
    }
}