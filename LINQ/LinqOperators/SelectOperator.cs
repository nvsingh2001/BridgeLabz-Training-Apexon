namespace LINQ.LinqOperators;

public class SelectOperator
{
    
    public static void main()
    {
        var numnbers = new List<int>() { 1, 2, 3, 4, 5 };
        
        var squaredNumbers = numnbers.Select(n => n * n);

        foreach (var item in squaredNumbers)
        {
            Console.Write(item + " ");
        }
    }
}