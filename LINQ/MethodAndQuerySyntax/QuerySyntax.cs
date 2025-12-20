namespace LINQ.MethodAndQuerySyntax;

public class QuerySyntax
{
    public static void Run()
    {
        List<string> myList = new List<string>() {
            "This is my Dog", "Name of my Dog is Robin",
            "This is my Cat","Name of the cat is Mewmew"
        };
        
        var result = from l  in myList where l.Contains("my") select l;

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

}