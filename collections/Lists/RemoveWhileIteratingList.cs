namespace collections.Lists;

public class RemoveWhileIteratingList
{
    static List<int> _list = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    public static void Display()
    {
        foreach (var item in _list)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    public static void RemoveEven()
    {
        for (int i = _list.Count - 1; i >= 0; i--)
        {
            if (_list[i] % 2 == 0)
            {
                _list.RemoveAt(i);
            }
        }
    }

    public static void RemoveAllMultipleOfThree()
    {
        _list.RemoveAll(num => num % 3 == 0);
    }
}