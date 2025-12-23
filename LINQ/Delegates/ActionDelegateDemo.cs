namespace LINQ.Delegates;

public class ActionDelegateDemo
{

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public static void Demo()
    {
        Action<string> printMessage = msg => Console.WriteLine(msg);
        Action<int, int> displaySum =  (x, y) => Console.WriteLine(x + y);
        Action<string> processName = name =>
        {
            string upper = name.ToUpper();
            Console.WriteLine($"Processed Name: {upper}");
        };
        Action<string> showMessage = ShowMessage;
        
        List<int> numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        
        printMessage("Hello World!");
        displaySum(10, 20);
        processName("John Doe");
        showMessage("Hello World! using named method");
        numbers.ForEach(n => Console.WriteLine($"Number: {n}"));
    }
}