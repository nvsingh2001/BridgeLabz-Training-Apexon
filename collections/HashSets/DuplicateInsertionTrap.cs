namespace collections.HashSets;

public class DuplicateInsertionTrap
{
    private static HashSet<int> _hashSet = new HashSet<int>();

    public static bool Insert(int value)
    {
        return _hashSet.Add(value);
    }

    public static void Display()
    {
        foreach (var item in _hashSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}