namespace LINQ.LambdaExpressions;

public class LambdaExpressionsDemo
{
    public static void Run()
    {
        List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 15, 29, 18, 27, 17, 9, 34 };
    
        Console.WriteLine("This list: " + string.Join(", ", numbers));
        
        var squares = numbers.Select(x => x * x);
        Console.WriteLine("Squares: " + string.Join(", ", squares));
        
        var divisibleBy3 = numbers.FindAll(x => x % 3 == 0);
        Console.WriteLine("Numbers Divisible by 3: " + string.Join(", ", divisibleBy3));
    }   
}