using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace collections.Hashtables;

public class HashtableRemoveWhileIterating
{
    static Hashtable table = new Hashtable()
    {
        {1,"Aman"},
        {2,"Riya"},
        {3,"Karan"},
        {4, "Neha"},
        {5, "Rohit"}
    };
    
    public static void Display()
    {
        foreach (var item in table)
        {
            Console.WriteLine(item);
        }
    }
    public static void Remove()
    {
        ArrayList keysToRemove = new ArrayList();
        foreach(var key in table.Keys)
        {
            if ((int)key % 2 == 0)
            {
                keysToRemove.Add(key);
            }
        }

        foreach (var key in keysToRemove)
        {
            table.Remove(key);
        }
    }
}