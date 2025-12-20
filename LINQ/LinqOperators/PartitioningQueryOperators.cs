namespace LINQ.LinqOperators;

public class PartitioningQueryOperators
{
    public static void Run()
    {
        var numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};

        var firstThree = numbers.Take(3);
        Console.WriteLine("Take Method: ");
        Console.WriteLine(string.Join(" ", firstThree));
        
        var lessThanFour = numbers.TakeWhile(x => x < 4);
        Console.WriteLine("TakeWhile Method: ");
        Console.WriteLine(string.Join(" ", lessThanFour));
    }
}