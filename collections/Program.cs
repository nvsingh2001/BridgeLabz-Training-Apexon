using collections.ArrayLists;
using collections.Dictionaries;
using collections.generics;
using collections.Hashtables;
using collections.Lists;
using collections.Queues;
using collections.SortedLists;
using collections.Stacks;

namespace collections;

class Program
{
    static void Main(string[] args)
    {
        MixedTypeArrayListFilter.Filter();
        RemoveWhileIterating.Display();
        RemoveWhileIterating.Remove();
        RemoveWhileIterating.Display();
        
        HashtableRemoveWhileIterating.Display();
        HashtableRemoveWhileIterating.Remove();
        Console.WriteLine();
        HashtableRemoveWhileIterating.Display();
        
        Console.WriteLine();
        KeyCollision.Display();
        Console.WriteLine();
        KeyCollision.AddUsingIndexer(91, "Sri Lanka");
        KeyCollision.Add(101,"India");
        KeyCollision.Display();
        
        Console.WriteLine();
        MixedStackPopTrap.Run();
        
        Console.WriteLine();
        PeekVsPop.PrintStackWithoutPop();
        
        Console.WriteLine();
        PeekVsPop.PrintStackWithoutPop();
        
        Console.WriteLine();
        MixedTypeQueueFiltering.DisplayQueue();
        Console.WriteLine();
        MixedTypeQueueFiltering.Filter();
        MixedTypeQueueFiltering.DisplayQueue();
        
        Console.WriteLine();
        KeySortingVsInsertionOrder.DisplayUsingForeach();
        Console.WriteLine();
        KeySortingVsInsertionOrder.DisplayKeys();
        Console.WriteLine();
        KeySortingVsInsertionOrder.DisplayValues();
        
        Console.WriteLine();
        DuplicateKeySortedList.Display();
        Console.WriteLine();
        DuplicateKeySortedList.KeyLookup();
        Console.WriteLine();
        DuplicateKeySortedList.IndexLookup();
        Console.WriteLine();

        GenericClass<int> integerGenericClass = new GenericClass<int>(10);
        integerGenericClass.Display();
        Console.WriteLine();
        
        GenericClass<string> stringGenericClass = new GenericClass<string>("Hello World");
        stringGenericClass.Display();
        Console.WriteLine();
        
        Pair<int, int> pair = new Pair<int, int>(1, 2);
        Pair<char, int> pair2 = new Pair<char, int>('a', 'b');
        pair.Display();
        pair2.Display();
        
        Console.WriteLine();
        RemoveWhileIteratingList.Display();
        // RemoveWhileIteratingList.RemoveEven();
        RemoveWhileIteratingList.RemoveAllMultipleOfThree();
        RemoveWhileIteratingList.Display();
        
        Console.WriteLine();
        // RemoveWhileIteratingDictionary.Display();
        // Console.WriteLine();
        // RemoveWhileIteratingDictionary.RemoveAllEven();
        // RemoveWhileIteratingDictionary.Display();
        // Console.WriteLine();

        try
        {
            RemoveWhileIteratingDictionary.Add(5, "Six");
            RemoveWhileIteratingDictionary.Display();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        RemoveWhileIteratingDictionary.Update(5, "Six");
        RemoveWhileIteratingDictionary.Display();

        var freq = CountFrequency.Frequency("naman");
        
        Console.WriteLine(freq);
        foreach (var item in freq)
        {
            Console.WriteLine(item);
        }
    }
}