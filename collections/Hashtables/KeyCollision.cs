using System.Collections;

namespace collections.Hashtables;

public class KeyCollision
{
    static Hashtable countryCode = new Hashtable()
    {
        {91, "India"},
        {1, "USA"},
        {44, "UK"}
    };
    
    public static void Display()
    {
        foreach (var item in countryCode)
        {
            Console.WriteLine(item);
        }
    }

    public static void Add(int code, string countryName)
    {
        countryCode.Add(code, countryName);
    }
    
    public static void AddUsingIndexer(int code, string countryName)
    {
        countryCode[code] =  countryName;
    }
}