using System.Collections;

namespace collections.Stacks;

using collections;
public class MixedStackPopTrap 
{
    static Stack stack = new Stack();

    static MixedStackPopTrap()
    {
        stack.Push(10);
        stack.Push("hello");
        stack.Push(20);
        stack.Push("world");
        stack.Push(30);
    }

    public static void Run()
    {
        while (stack.Count != 0)
        {
            var pop = stack.Pop();
            if (pop is int)
            {
                Console.WriteLine(pop);
            }
        }
    }
}