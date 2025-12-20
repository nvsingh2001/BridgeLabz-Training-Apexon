namespace LINQ.LinqOperators;

public class SelectManyOperators
{
    public static void Run()
    {
        var numbers = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };

        var flattenedNumbers = numbers.SelectMany(number => number);

        foreach (var number in flattenedNumbers)
        {
            Console.Write(number + " ");
        }
    }
}