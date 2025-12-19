namespace collections.SortedGenericCollections;

public class SortedDictionaryOperations
{
    private static SortedDictionary<int , string> _sortedDictionary = new()
    {
        { 10, "Ten"},
        { 1, "One"},
        { 5, "Five"},
        { 3,  "Three"}
    };

    public static void PrintSortedDictionary()
    {
        foreach (var entry in _sortedDictionary)
        {
            Console.WriteLine($"{entry.Key} - {entry.Value}");
        }
    }

    public static void RemoveInRange(int i)
    {
        var keyToRemove = new List<int>();
        foreach (var key in _sortedDictionary.Keys)
        {
            if (key > i)
            {
                keyToRemove.Add(key);
            }
        }

        foreach (var key in keyToRemove)
        {
            _sortedDictionary.Remove(key);
        }
    }
}