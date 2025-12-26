using System.Text;

namespace FileHandling;

public class StringReaderAndWriterDemo
{
    public static void WriteStringToFile(string content, string filePath)
    {
        var sb = new StringBuilder();
        using var writer = new StringWriter(sb);
        
        writer.Write(content);
        writer.Flush();
        writer.Close();
        
        var reader = new StringReader(sb.ToString());

        while (reader.Peek() > -1)
        {
            Console.WriteLine(reader.ReadLine());
        }
        Console.ReadKey();
    }
}