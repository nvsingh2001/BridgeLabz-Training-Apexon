namespace collections;

internal class LinkedLists
{
    private static LinkedList<int> _linkedList = new LinkedList<int>();

    static LinkedLists()
    {
        _linkedList.AddLast(1);
        _linkedList.AddLast(2);
        _linkedList.AddLast(3);
        _linkedList.AddLast(4);
        _linkedList.AddLast(5);
    }

    public static int GetLinkedListElement(int i)
    {
        return _linkedList.ElementAt(i);
    }

    public static void PrintLinkedList()
    {
        foreach (int i in _linkedList)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static void DeleteEvenNode()
    {
        var currentNode = _linkedList.First;

        while (currentNode != null)
        {
            var nextNode = currentNode.Next;
            
            if (currentNode.Value % 2 == 0)
            {
                _linkedList.Remove(currentNode);
            }

            currentNode = nextNode;
        }
    }

    public static void InsertNodes()
    {
        var currentNode = _linkedList.First;
        while(currentNode != null)
        {
            
            if(currentNode.Value == 1)
            {
                _linkedList.AddAfter(currentNode, 2);
            }

            if (currentNode.Value == 3)
            {
                _linkedList.AddAfter(currentNode, 4);
            }
            
            currentNode = currentNode.Next;
        }
    }
}