namespace collections.SortedGenericCollections;

public class SortedSetProblem
{
    static SortedSet<int>  _sortedSet = new();

    static SortedSetProblem()
    {
        _sortedSet.Add(5);
        _sortedSet.Add(3);
        _sortedSet.Add(8);
        _sortedSet.Add(3);
        _sortedSet.Add(1);
        _sortedSet.Add(5);
    }

    public static void PrintSortedSet()
    {
        foreach (int i in _sortedSet)
        {
            Console.Write(i + " ");
        }
    }
}