namespace ExceptionHandling.CustomException;

public class CustomExceptionClassDemo
{
    public static void Divide()
    {
        try
        {
            Console.WriteLine("Enter first number: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            var number2 = int.Parse(Console.ReadLine());
            if (number2 % 2 != 0)
            {
                throw new OddNumberException("Denominator cannot be odd numbers");
            }
            var result = number1 / number2;
            Console.WriteLine($"Result = {result}");
        }
        catch (OddNumberException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine(ex.Source);
            Console.WriteLine(ex.HelpLink);
        }
    }
}