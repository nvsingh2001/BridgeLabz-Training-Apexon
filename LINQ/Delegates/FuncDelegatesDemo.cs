namespace LINQ.Delegates;

public class FuncDelegatesDemo
{
    static int Cube(int n)
    {
        return n * n * n;
    }
    public static void Run()
    {
        var numbers = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        Func<int, int> square = x => x * x;
        Func<int, int, int> add = (x, y) => x + y;
        Func<string> greet = () => "Hello World!";
        Func<int, int, int> multiply = (x, y) =>
        {
            var result = x * y;
            return result;
        };
        Func<int, int> cubeFunc = Cube;
        Func<int, bool> isEven = x => x % 2 == 0;
        
        Console.WriteLine(square(3));
        Console.WriteLine(add(3, 4));
        Console.WriteLine(greet());
        Console.WriteLine(multiply(3, 4));
        Console.WriteLine(cubeFunc(9));
        Console.WriteLine(string.Join(Environment.NewLine, numbers.Where(isEven)));
    }
}