namespace collections.SortedGenericCollections;

public class SortedListProblem
{
    static SortedList<int, string>  _sortedList = new  SortedList<int, string>()
    {
        {3, "Three"},
        {1, "One"},
        {4, "Four"},
        {2, "Two"},
    };

    public static void PrintUsingForeachLoop()
    {
        foreach (var item in _sortedList)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }

    public static void PrintUsingForLoop()
    {
        for (int i = 0; i < _sortedList.Count; i++)
        {
            Console.WriteLine(_sortedList.Keys[i] + " -> " + _sortedList.Values[i]);
        }
    }
}