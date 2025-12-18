using System.Collections;

namespace collections.Stacks;

public class PeekVsPop
{
    static Stack stack = new  Stack();

    static PeekVsPop()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
    }
    
    public static void PrintStackWithoutPop()
    {
        Stack copyStack = new Stack();
        while (stack.Count > 0)
        {
            var item = stack.Pop();
            Console.WriteLine(item);
            copyStack.Push(item);
        }

        while (copyStack.Count > 0)
        {
            stack.Push(copyStack.Pop());
        }
    }
}