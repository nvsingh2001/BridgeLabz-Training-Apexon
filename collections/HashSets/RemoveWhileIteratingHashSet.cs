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
        try
        {
            foreach (var item in _hashSet)
            {
                _hashSet.Remove(item);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void RemoveAllEven()
    {
        _hashSet.RemoveWhere(x => x % 2 == 0);
    }
}