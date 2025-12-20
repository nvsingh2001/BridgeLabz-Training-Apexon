namespace LINQ.LinqOperators;

public class WhereOperator
{
    public static void Run()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbers)
        {
            Console.Write(number + " ");
        }
    }
}