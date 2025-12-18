using System.Collections;

namespace collections.SortedLists;

public class KeySortingVsInsertionOrder
{
    static SortedList sortedList = new SortedList()
    {
        {3, "Three"},
        {1, "One"},
        {4, "Four"},
        {2, "Two"}
    };

    public static void DisplayUsingForeach()
    {
        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }
    }

    public static void DisplayKeys()
    {
        for(int i = 0; i < sortedList.Count; i++)
        {
            Console.WriteLine(sortedList.GetKey(i));
        }
    }

    public static void DisplayValues()
    {
        for (int i = 0; i < sortedList.Count; i++)
        {
            Console.WriteLine(sortedList.GetByIndex(i));
        }
    }
}