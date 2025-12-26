namespace FileHandling;

public class FileInfoDemo
{
    public static void CreateAFile(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        fileInfo.Create();
        {
            Console.WriteLine("File has been created.");
        }
        Console.ReadKey();
    }

    public static void WriteStringToFile(string content, string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        StreamWriter streamWriter = fileInfo.CreateText();
        streamWriter.Write(content);
        Console.WriteLine("File has been created with Text.");
        streamWriter.Close();
        Console.ReadKey();
    }

    public static void DeleteFile(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        fileInfo.Delete();
        {
            Console.WriteLine("File has been deleted.");
        }
        Console.ReadKey();
    }

    public static void MoveFile(string sourceFilePath, string destinationFilePath)
    {
        FileInfo fileInfo = new FileInfo(sourceFilePath);
        fileInfo.MoveTo(destinationFilePath);
        Console.WriteLine($"{sourceFilePath} has been moved to {destinationFilePath}");
        Console.ReadKey();
    }

    public static void GetFileInfo(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        
        Console.WriteLine("File Created on : " + fileInfo.CreationTime);
        Console.WriteLine("Directory Name : " + fileInfo.DirectoryName);
        Console.WriteLine("Name of File : " + fileInfo.Name);
        Console.WriteLine("Full Name of File : " + fileInfo.FullName);
        Console.WriteLine("Length of File : " + fileInfo.Length);
        Console.WriteLine("Is Readonly : " + fileInfo.IsReadOnly);
        Console.WriteLine("File is Last Accessed on : " + fileInfo.LastAccessTime);
    }
}