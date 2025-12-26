namespace FileHandling;

public class FileStreamDemo
{
    public static void CheckFileExists(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine("File exists");
        }
        else
        {
            Console.WriteLine("File does not exist");
        }

        Console.ReadKey();
    }

    public static void ReadFileAllLines(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine(string.Join(Environment.NewLine, File.ReadAllLines(filePath)));
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
        Console.ReadKey();
    }
    
    public static void ReadTextFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine(File.ReadAllText(filePath));
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
        Console.ReadKey();
    }

    public static void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        if (File.Exists(sourceFilePath))
        {
            File.Copy(sourceFilePath, destinationFilePath, true);
            Console.WriteLine("File copied successfully");
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
        Console.ReadKey();
    }

    public static void WriteAllLineFile(string filePath, string[] content)
    {
        if (File.Exists(filePath))
        {
            File.WriteAllLines(filePath, content);
            Console.WriteLine("File written successfully");
        }
        else
        {
            Console.WriteLine("File does not exist");
        }
        Console.ReadKey();
    }

    public static void CreateFile(string filePath)
    {
        using var fs = File.Create(filePath);
        Console.WriteLine("File created successfully");
        Console.ReadKey();
    }
}