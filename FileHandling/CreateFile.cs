namespace FileHandling;

public class CreateFile
{
    public static void Run(string filePath)
    {
        string FilePath = filePath; 
        FileStream fileStream = new FileStream(FilePath, FileMode.Create);
        
        fileStream.Close();
        Console.WriteLine("File has been created and the path is " + FilePath);
        Console.ReadKey();
    }
}