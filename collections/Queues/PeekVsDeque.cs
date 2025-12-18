using System.Collections;

namespace collections.Queues;

public class PeekVsDeque
{
    private static Queue queue = new Queue();

    static PeekVsDeque()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
    }

    public static void PrintWithoutDeque()
    {
        Queue copyQueue = new Queue();
        while (queue.Count > 0)
        {
            Console.Write(queue.Peek() + " ");
            copyQueue.Enqueue(queue.Dequeue());
        }

        while (copyQueue.Count > 0)
        {
            queue.Enqueue(copyQueue.Dequeue());
        }
    }
}