using System.Collections;
namespace collections.ArrayLists;

public class RemoveWhileIterating
{
    private static ArrayList _arrayList = new ArrayList(){};

    public static void Display()
    {
        foreach (int i in _arrayList)
        {
            Console.Write(i + " ");
        }
        
        Console.WriteLine();
    }
    
    

    public static void Remove()
    {
        for (int i = _arrayList.Count - 1; i >= 0; i--)
        {
            if((int)_arrayList[i]! % 2 == 0)
            {
                _arrayList.RemoveAt(i);
            }
        }
    }
}
