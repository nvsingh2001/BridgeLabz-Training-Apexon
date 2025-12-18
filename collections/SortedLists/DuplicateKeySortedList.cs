using System.Collections;

namespace collections.SortedLists;

public class DuplicateKeySortedList 
{
    static SortedList sortedList = new();

    static DuplicateKeySortedList()
    {
        try
        {
            sortedList.Add(1, "One");
            sortedList.Add("2", "Three");
            sortedList.Add(1, "Two");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void Display()
    {
        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }
    }

    public static void KeyLookup()
    {
        foreach (var i in sortedList.Keys)
        {
            Console.WriteLine(sortedList[i]);
        }
    }
    
    public static void IndexLookup()
    {
        for (int i = 0; i < sortedList.Count; i++)
        {
            Console.WriteLine(sortedList.GetByIndex(i));
        }
    }
}