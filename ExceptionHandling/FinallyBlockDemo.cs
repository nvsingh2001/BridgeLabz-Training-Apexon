namespace ExceptionHandling;

public class FinallyBlockDemo
{
    public static void Demo()
    {
        try
        {
            Environment.Exit(0);
        }
        finally
        {
            Console.WriteLine("Finally Ran");
        }
        
    }

}