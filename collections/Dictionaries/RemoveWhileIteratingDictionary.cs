namespace collections.Dictionaries;

public class RemoveWhileIteratingDictionary
{
    static Dictionary<int, string> dictionary = new Dictionary<int, string>()
    {
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, "Four"},
        {5, "Five"},
    };

    public static void Display()
    {
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

    public static void RemoveAllEven()
    {
        foreach (var item in dictionary.Keys)
        {
            if (item % 2 == 0)
            {
                dictionary.Remove(item);
            }
        }
    }

    public static void Add(int key, string value)
    {
        dictionary.Add(key, value);
    }

    public static void Update(int key, string value)
    {
        dictionary[key] = value;
    }

    public static string SafeAccess(int key)
    {
        dictionary.TryGetValue(key, out string value);
        if(value == null) value = "";
        return value;
    }
}