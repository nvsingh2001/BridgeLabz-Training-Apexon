namespace collections.SortedGenericCollections;

public class SortedSetRangeOperation
{
    private static SortedSet<int> _sortedSet = new();

    static SortedSetRangeOperation()
    {
        for(int i = 1; i <= 10; i++)
        {
            _sortedSet.Add(i);
        }
    }

    public static void GetRangeValue(int i, int j)
    {
        foreach (var value in _sortedSet.GetViewBetween(i, j))
        {
            Console.Write(value + " ");
        }
    }

    public static void RemoveValue(int i)
    {
        _sortedSet.RemoveWhere(x => x < i);
    }
    
    public static void PrintSortedSet()
    {
        foreach (int i in _sortedSet)
        {
            Console.Write(i + " ");
        }
    }
}