using System.Collections;
namespace collections.ArrayLists;

public class MixedTypeArrayListFilter
{
    static System.Collections.ArrayList _arrayList = new System.Collections.ArrayList(){100, "Naman", "Vinay", "Singh", 8.98, 900, null};
    
    public static void Filter()
    {
        int sum = 0;
        int count = 0;

        foreach (var item in _arrayList)
        {
            if (item is null) continue;

            if (item is int)
            {
                sum += (int)item;
            }
            
            if(item.GetType() == typeof(string)) count++;
            
        }
        Console.WriteLine($"Sum of all intgers= {sum}");
        Console.WriteLine($"Count of all strings= {count}");
    } 
}