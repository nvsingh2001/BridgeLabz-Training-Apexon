namespace LINQ.LinqOperators;

public class SkipAndSkipWhile
{
    public static void Run()
    {
        var numbers = new List<int>(){1, 2, 3, 4, 5};
        
        var afterThree = numbers.Skip(3);
        Console.WriteLine("Skip method: ");
        Console.WriteLine(string.Join(" ", afterThree));
        
        var skipWhileLessThanFour = numbers.SkipWhile(x => x < 4);
        Console.WriteLine("SkipWhile Method: ");
        Console.WriteLine(string.Join(" ", skipWhileLessThanFour));
    }
}