namespace LINQ.LinqOperators;

public class SetOperator
{
    public static void Run()
    {
        var numbers = new[] { 1, 1, 2, 2, 3, 3, 4, 5 };
        
        var uniqueNumbers = numbers.Distinct();
        
        Console.WriteLine("Unique Numbers: ");
        Console.WriteLine(string.Join(", ", uniqueNumbers));
    }
}