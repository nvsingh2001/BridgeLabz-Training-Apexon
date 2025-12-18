namespace collections.generics;

public class GenericClass<T>
{
    private T _value;

    public GenericClass(T value)
    {
        _value = value;
    }

    public void Display()
    {
        Console.WriteLine(_value);
    }
}