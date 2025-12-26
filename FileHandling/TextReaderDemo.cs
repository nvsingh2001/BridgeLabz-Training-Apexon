namespace FileHandling;

public class TextReaderDemo
{
    public static void ReadLineFromFile(string filePath)
    {
        using var reader = new StreamReader(filePath);
        Console.WriteLine(reader.ReadLine());
        Console.ReadKey();
    }

    public static void ReadFourCharacters(string filePath)
    {
        using var reader = new StreamReader(filePath);
        char[] buffer = new char[4];
        reader.ReadBlock(buffer, 0, 4);
        Console.WriteLine(buffer);
        Console.ReadKey();
    }

    public static void ReadFullFile(string filePath)
    {
        using var reader = new StreamReader(filePath);
        Console.WriteLine(reader.ReadToEnd());
        Console.ReadKey();
    }
}