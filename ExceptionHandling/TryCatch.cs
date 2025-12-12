namespace ExceptionHandling;
using System;

internal class TryCatch
{
    public static void Divide()
    {
        int number1, number2, result;
        try
        {
            Console.WriteLine("Enter first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            number2 = int.Parse(Console.ReadLine());
            result = number1 / number2;
            Console.WriteLine($"Result = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine(ex.Source);
            Console.WriteLine(ex.HelpLink);
        }
    }
}