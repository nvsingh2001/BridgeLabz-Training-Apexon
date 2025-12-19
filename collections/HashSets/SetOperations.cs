namespace collections.HashSets;

public class SetOperations
{
    public static HashSet<int> A { get; set; }= new HashSet<int>(){1, 2, 3, 4};
    public static  HashSet<int> B { get; set; } = new HashSet<int>() { 3, 4, 5, 6 };

    public static void Indexer()
    {
        for (int i = 0; i < A.Count; i++)
        {
            Console.Write(A.ElementAt(i) + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < B.Count; i++)
        {
            Console.Write(B.ElementAt(i) + " ");
        }
        Console.WriteLine();
    }
    public static void ComputeUnion()
    {
        foreach(var item in A.Union(B))
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void ComputeIntersect()
    {
        foreach (var item in A.Intersect(B))
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void ComputeDifference()
    {
        foreach (var item in A.Except(B))
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        foreach (var item in B.Except(A))
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}