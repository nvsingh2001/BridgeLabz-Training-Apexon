namespace FileHandling;

public class StreamWriterDemo
{
    public static void WriteToFile(string filePath, string content)
    {
        using var writer = new StreamWriter(filePath, true);
        writer.Write(content);
        Console.WriteLine("Data has been Written to the File");
    }
}