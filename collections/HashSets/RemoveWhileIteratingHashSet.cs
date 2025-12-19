namespace collections.HashSets;

public class RemoveWhileIteratingHashSet
{
    private static HashSet<int> _hashSet = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
    public static void Display()
    {
        foreach (var item in _hashSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void RemoveAllEvenWrongWay()
    {
        List<int> toRemove = new List<int>();

        foreach (var item in _hashSet)
        {
            if (item % 2 == 0)
            {
                toRemove.Add(item);
            }
        }

        foreach (var item in toRemove)
        {
            _hashSet.Remove(item);
        }
    }

    public static void RemoveAllEven()
    {
        _hashSet.RemoveWhere(x => x % 2 == 0);
    }
}