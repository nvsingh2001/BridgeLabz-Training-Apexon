namespace ExceptionHandling;

public class MultipleCatchBlock
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
        catch (DivideByZeroException DBZE)
        {
            Console.WriteLine(DBZE.Message);
        }
        catch (FormatException FEX) 
        {
            Console.WriteLine(FEX.Message);
        }
        catch (OverflowException OVERFLOW)
        {
            Console.WriteLine(OVERFLOW.Message);
        }
    }
}