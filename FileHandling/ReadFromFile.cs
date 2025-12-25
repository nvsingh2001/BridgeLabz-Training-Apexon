namespace FileHandling;

public class ReadFromFile
{
    public static void ReadFile(string filePath)
    {
        string content;
        
        FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        using (StreamReader reader = new StreamReader(fileStream))
        {
            content = reader.ReadToEnd();
        }
        
        Console.WriteLine($"Content: {content}");
        Console.ReadKey();
    }
}