namespace LINQ.Delegates;

public class Predicates
{
    static bool CheckPositive(int number)
    {
        return number > 0;
    }

    public static void Run()
    {
        Predicate<int> isPositive = CheckPositive;
        
        Console.WriteLine(isPositive(6));
        Console.WriteLine(isPositive(-19));
        
        List<int> numbers = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        Predicate<int> isEven = n => n % 2 == 0;

        var firstEven = numbers.Find(isEven);
        var allEven = numbers.FindAll(isEven);
        
        Console.WriteLine($"First Even: {firstEven}");
        
        Console.WriteLine("All Even Numbers: ");
        allEven.ForEach(n => Console.WriteLine(n));
    }
    
}