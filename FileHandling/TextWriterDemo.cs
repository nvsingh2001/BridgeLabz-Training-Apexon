namespace FileHandling;

public class TextWriterDemo
{
    public static async void WriteCharAsync(string filePath)
    {
        using (TextWriter writer = File.CreateText(filePath))
        {
            await writer.WriteLineAsync("Hello World form TextWriter.");

            await writer.WriteLineAsync("File Handling Tutorial in C#");
        }
        Console.WriteLine("Async Write Successfully");
    }
}