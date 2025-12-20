namespace LINQ.MethodAndQuerySyntax;

public class MethodSyntax
{
    public static void Run()
    {
        List<string> myList = new List<string>()
        {
            "This is my Dog",
            "Name of my Dog is Robin",
            "This is my cat",
            "Name  of the cat is Mewmew"
        };

        var res = myList.Where(l => l.Contains("my")).Select(l => l);

        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
    }
}